using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G1 : MonoBehaviour
{
    void Start()
    {
        Material material = new Material(Shader.Find("Transparent/Diffuse"));
        material.color = Color.black;
        GetComponent<Renderer>().material = material;
        InvokeRepeating("GreenTurn", 0f, 33f);
        InvokeRepeating("TurnBlack", 13.5f, 33f);
    }

    void Update()
    {

    }
    void GreenTurn()
    {
        Material material1 = new Material(Shader.Find("Transparent/Diffuse"));
        material1.color = Color.green;
        GetComponent<Renderer>().material = material1;
    }
    void TurnBlack()
    {
        Material material2 = new Material(Shader.Find("Transparent/Diffuse"));
        material2.color = Color.black;
        GetComponent<Renderer>().material = material2;
    }
}
