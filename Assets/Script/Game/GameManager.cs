using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // static : ���α׷��� ����� ������ �޸𸮿��� ����ֽ��ϴ�.
    // ������ ������ ����˴ϴ�.
    public static GameManager instance;
    public float speed;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        
    }

    
    void Update()
    {
        
    }
}
