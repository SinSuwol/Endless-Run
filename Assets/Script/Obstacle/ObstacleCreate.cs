using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{
    public GameObject obstacle;

    
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
        Instantiate(obstacle, new Vector3(0, 0.2f, 7.5f), Quaternion.identity);
    }
}
