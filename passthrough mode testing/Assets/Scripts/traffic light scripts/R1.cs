using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R1 : MonoBehaviour
{
    public enum TrafficLightState { Red, Green }
    public static TrafficLightState currentState = TrafficLightState.Green; 
    void Start()
    {
        Material material = new Material(Shader.Find("Transparent/Diffuse"));
        material.color = Color.black;
        GetComponent<Renderer>().material = material;
        InvokeRepeating("RedTurn", 15f, 33f);
        InvokeRepeating("TurnBlack", 33f, 33f);
    }
        void Update()
        {

        }
        void RedTurn()
        {
            Material material1 = new Material(Shader.Find("Transparent/Diffuse"));
            material1.color = Color.red;
            GetComponent<Renderer>().material = material1;
            currentState = TrafficLightState.Red; // 设置为红灯状态
    }
        void TurnBlack()
        {
            Material material2 = new Material(Shader.Find("Transparent/Diffuse"));
            material2.color = Color.black;
            GetComponent<Renderer>().material = material2;
            currentState = TrafficLightState.Green; // 设置为绿灯状态
    }
    public static TrafficLightState GetCurrentState()
    {
        return currentState;
    }
}

