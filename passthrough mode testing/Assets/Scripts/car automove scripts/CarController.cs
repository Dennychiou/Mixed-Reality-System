using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 5f;

    private bool isStopped = false;

    void Update()
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

        if (!isStopped)
        {
            // 车辆行驶逻辑
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}