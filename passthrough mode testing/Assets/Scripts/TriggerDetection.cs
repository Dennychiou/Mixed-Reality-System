using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    public GameObject RawImage; 

    void Start()
    {
        RawImage.SetActive(false); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            Debug.Log("DetectionObject has triggered with the car!");
            RawImage.SetActive(true);
            Debug.Log("RawImage active state: " + RawImage.activeSelf); 
        }
    }

}
