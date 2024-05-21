using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Automove : MonoBehaviour
{
    public float speed = 5f;
    public Transform TrafficLight;
    public Transform Plane;
    private bool isStopped = false;

    void Update()
    {
        // 检查红绿灯状态
        float distanceToPlane = UnityEngine.Vector3.Distance(transform.position, Plane.position);

        if (R1.GetCurrentState() == R1.TrafficLightState.Red && distanceToPlane <= 1f && transform.position.z < Plane.position.z)
        {
            // 如果是红燈並且在 Plane 前方 1 單位内，則停车
            isStopped = true;
            Debug.Log("Red light: Car is stopping");
        }
        else if (R1.GetCurrentState() == R1.TrafficLightState.Green || transform.position.z >= Plane.position.z + 1f)
        {
            // 如果是绿燈或已经通過 Plane，則行驶
            isStopped = false;
            Debug.Log("Green light or passed Plane: Car is moving");
        }

        if (!isStopped)
        {
            // 车辆行驶逻辑
            transform.Translate(UnityEngine.Vector3.forward * speed * Time.deltaTime);
        }
        Debug.Log("Automove Update: isStopped=" + isStopped + ", speed=" + speed);
    }
    void CheckTrafficLightState()
    {
        // 检查红绿灯状态
        if (R1.GetCurrentState() == R1.TrafficLightState.Red)
        {
            // 停车
            isStopped = true;
        }
        else if (R1.GetCurrentState() == R1.TrafficLightState.Green)
        {
            // 行驶
            isStopped = false;
        }
    }
}
