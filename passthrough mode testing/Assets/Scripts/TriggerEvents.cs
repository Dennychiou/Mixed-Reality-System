using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{
    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Invisible Plane" && !hasTriggered)
        {
            hasTriggered = true;
            Destroy(gameObject);

            if (Spawner.Instance != null)
            {
                Debug.Log("Spawning new car in TriggerEvents script (OnTriggerEnter).");
                Debug.Log("Tunnel position: " + Spawner.Instance.tunnel.position);
                Spawner.Instance.SpawnObject();
            }
            else
            {
                Debug.LogError("Spawner instance is not set in TriggerEvents script.");
            }
        }
    }

    void Start()
    {
        // 确保 Spawner 的实例在 Start 方法中设置
        if (Spawner.Instance == null)
        {
            Debug.LogError("Spawner instance is not set in TriggerEvents script (Start).");
        }
        else
        {
            Debug.Log("Spawner instance is set correctly in TriggerEvents script (Start).");
        }
    }

    void Update()
    {

    }
}
