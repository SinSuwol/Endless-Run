using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{
    void Start()
    {
        // InvokeRepeating : �� ���Ŀ� �Լ��� ����ǰ�, Ư���� �ð����� �Լ��� �ݺ������� ����Ǵ� �Լ��Դϴ�. 
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
