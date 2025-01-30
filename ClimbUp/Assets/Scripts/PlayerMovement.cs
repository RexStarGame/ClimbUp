using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    public float gravity;
    public float fallSpeed;
    public float fallSpeedMultiplier;

    float inputHorizontal;
    float inputVertical;

    private float Move;

    public Rigidbody2D rb;

    public bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(Move * speed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }
        Gravity();

        flip();
    }

    private void flip()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        
        if (inputHorizontal != 0f)
        {
            Vector3 currentScale = gameObject.transform.localScale;
            gameObject.transform.localScale = new Vector3(-Mathf.Sign(inputHorizontal) * Mathf.Abs(currentScale.x), currentScale.y, currentScale.z);
        }

    }

    private void Gravity()
    {
        if (rb.velocity.y < 0) 
        {
            rb.gravityScale = gravity * fallSpeedMultiplier;
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Max(rb.velocity.y, -fallSpeed));
        }
        else
        {
            rb.gravityScale = gravity;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }
}
