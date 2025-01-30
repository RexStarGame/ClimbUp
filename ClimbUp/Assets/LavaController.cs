using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f; 
    [SerializeField] private float startDelay = 10f; 
    private Rigidbody2D rb2D;
    private bool isRising = false; 

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        StartCoroutine(StartLavaRise()); 
    }

    private IEnumerator StartLavaRise()
    {
        yield return new WaitForSeconds(startDelay); 
        isRising = true; 
    }

    private void Update()
    {
        if (isRising)
        {
            rb2D.velocity = new Vector2(0f, moveSpeed); 
        }
        else
        {
            rb2D.velocity = Vector2.zero; 
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Time.timeScale = 0; 
        }
    }
}
