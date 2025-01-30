using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeightManager : MonoBehaviour
{
    [SerializeField] private Transform startPoint;

    [SerializeField] private TextMeshProUGUI heightText;

    [SerializeField] private Transform player;

    private float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        height = (startPoint.transform.position - transform.position).magnitude;

        heightText.text = "Height: " + height.ToString("F1") + " meters";
        
    }
}
