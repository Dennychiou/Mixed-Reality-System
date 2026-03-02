using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarSpawnerController : MonoBehaviour
{
    public Spawner spawnScript; 
    private bool hasSpawned = false;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One) && !hasSpawned)
        {
            hasSpawned = true;
            if (spawnScript != null)
            {
                Debug.Log("Spawning new car.");
                spawnScript.SpawnObject();
            }
            else
            {
                Debug.LogError("Spawner reference is not set in CarSpawnerController script.");
            }
        }
    }
}
