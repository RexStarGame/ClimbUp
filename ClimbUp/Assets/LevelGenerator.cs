using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject floors;
    private List<Vector2> floorsList = new();
    private void flip(GameObject go, Transform tra)
    {
        float tempRot = 0f;
        if (Mathf.Approximately(tra.rotation.y, 0f))
        {
            tempRot = 180;
        }
        go.transform.rotation = new Quaternion(go.transform.rotation.x, tempRot, go.transform.rotation.z, go.transform.rotation.w);
    }

    internal void SpawnNewLevel(Transform tra)
    {
        if(floorsList.Contains(tra.position))
        {
            return;
        }
        GameObject go = Instantiate(floors, new Vector2(0, tra.position.y + 10.06f), Quaternion.identity);
        if(go.TryGetComponent(out LevelController levelController))
        {
            levelController.levelGenerator = this;
        }
        floorsList.Add(tra.transform.position);
        flip(go, tra);
    }
}
