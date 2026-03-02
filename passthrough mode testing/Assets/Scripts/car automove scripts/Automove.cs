using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Automove : MonoBehaviour{
public float speed = 5f;
public Transform TrafficLight;
public Transform Plane;
private bool isStopped = false;

void Update(){
    float distanceToPlane = UnityEngine.Vector3.Distance(transform.position, Plane.position);

    if (R1.GetCurrentState() == R1.TrafficLightState.Red && distanceToPlane <= 1f && transform.position.z < Plane.position.z){
        isStopped = true;
        Debug.Log("Red light: Car is stopping");
        }
    else if (R1.GetCurrentState() == R1.TrafficLightState.Green || transform.position.z >= Plane.position.z + 1f){
        isStopped = false;
        Debug.Log("Green light or passed Plane: Car is moving");
        }

    if (!isStopped){
        transform.Translate(UnityEngine.Vector3.forward * speed * Time.deltaTime);
        }
        Debug.Log("Automove Update: isStopped=" + isStopped + ", speed=" + speed);
}
void CheckTrafficLightState(){
    if (R1.GetCurrentState() == R1.TrafficLightState.Red){
            isStopped = true;
        }
    else if (R1.GetCurrentState() == R1.TrafficLightState.Green){
        isStopped = false;
        }
    }
}
