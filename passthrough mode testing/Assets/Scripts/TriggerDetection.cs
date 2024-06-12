using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    public GameObject RawImage; // 指向你的 RawImage 物件

    void Start()
    {
        RawImage.SetActive(false); // 初始時隱藏 RawImage
    }

    void OnTriggerEnter(Collider other)
    {
        // 檢查碰撞物是否為車輛
        if (other.CompareTag("Car"))
        {
            Debug.Log("DetectionObject has triggered with the car!");
            RawImage.SetActive(true); // 顯示 RawImage
            Debug.Log("RawImage active state: " + RawImage.activeSelf); // 输出 RawImage 的活动状态
        }
    }
}