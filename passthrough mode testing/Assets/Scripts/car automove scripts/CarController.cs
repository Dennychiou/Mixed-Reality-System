using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour{
    public float speed = 5f;
    private bool isStopped = false;
    void Update(){
        if (R1.GetCurrentState() == R1.TrafficLightState.Red){
            isStopped = true;
        }
        else if (R1.GetCurrentState() == R1.TrafficLightState.Green){
            isStopped = false;
        }
        if (!isStopped){
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
