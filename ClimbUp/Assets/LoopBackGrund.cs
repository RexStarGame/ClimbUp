using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBackGrund : MonoBehaviour
{
    public float backgrundSpeed;
    public Renderer backgrudnRender;
    
    void Update()
    {
        backgrudnRender.material.mainTextureOffset += new Vector2(0f, backgrundSpeed * Time.deltaTime);
    }
}
