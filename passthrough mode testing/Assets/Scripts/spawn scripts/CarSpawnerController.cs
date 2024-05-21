using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarSpawnerController : MonoBehaviour
{
    public Spawner spawnScript;  // 引用 Spawner 脚本
    private bool hasSpawned = false;

    void Update()
    {
        // 检测 Oculus Touch 控制器的 A 按键输入
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