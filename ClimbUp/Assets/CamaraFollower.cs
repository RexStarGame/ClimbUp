using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollower : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector2 officeX_;
    [SerializeField] private Vector2 officeY_;
    [SerializeField] private Vector2 _camraPos;


    private void FixedUpdate()
    {
        CalculateCamaraPosition();
        transform.position = _camraPos;
    }
    void CalculateCamaraPosition()
    {

    }
}
