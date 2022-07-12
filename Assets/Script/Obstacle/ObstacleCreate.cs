using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{
    void Start()
    {
        // InvokeRepeating : 몇 초후에 함수가 실행되고, 특성한 시간마다 함수가 반복적으로 실행되는 함수입니다. 
        InvokeRepeating("Create", 5, 5);
    }

    void Update()
    {
        
    }
    public void Create()
    {
        if (GameManager.instance.state == false) return;

        ObjectPool.Instance.GetQueue();
    }
}
