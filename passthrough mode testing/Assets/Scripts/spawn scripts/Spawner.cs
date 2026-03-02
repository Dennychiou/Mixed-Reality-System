using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance { get; private set; }

    public GameObject objectToSpawn;
    public Transform tunnel;
    public Transform TrafficLight;
    public Transform Plane;
    public float carSpeed = 5f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Multiple instances of Spawner found!");
            Destroy(gameObject);
        }

        if (tunnel == null)
        {
            Debug.LogError("Tunnel reference is not set in Spawner script.");
        }
        else
        {
            Debug.Log("Tunnel reference is set correctly in Spawner script (Awake).");
        }
    }

    void Start()
    {
        SpawnObject();
    }

    public void SpawnObject()
    {
        if (tunnel != null && TrafficLight != null && Plane != null)
        {
            UnityEngine.Vector3 spawnPosition = tunnel.position;
            UnityEngine.Quaternion spawnRotation = tunnel.rotation;
            GameObject car = Instantiate(objectToSpawn, spawnPosition, spawnRotation);

            Automove automove = car.GetComponent<Automove>();
            if (automove == null)
            {
                automove = car.AddComponent<Automove>();
            }
            automove.speed = carSpeed;
            automove.TrafficLight = TrafficLight;
            automove.Plane = Plane;
            Debug.Log("Car spawned at specific position and Automove script added.");
        }
        else
        {
            Debug.LogError("Tunnel reference is not set in Spawner script (SpawnObject).");
        }
    }
}
