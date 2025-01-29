using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public LevelGenerator levelGenerator;
    private void OnTriggerExit2D(Collider2D other)
    {
     if(other.CompareTag("Player"))
        {
            levelGenerator.SpawnNewLevel(transform);
            
        }
    }

}
