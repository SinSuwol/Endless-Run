using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager ���� �������� ��������
    // static : ���α׷��� ����� ������ �޸𸮿��� ����ֽ��ϴ�.
    // ������ ������ ����˴ϴ�.
    public static GameManager instance;

    public float speed;
    public bool state;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        state = true;

        StartCoroutine(SpeedIncrease());
    }

    IEnumerator SpeedIncrease()
    {
        while (state)
        {
            yield return new WaitForSeconds(1f);
            speed++;

            if(state == false)
            {
                speed = 0;
            }
            if(speed >= 50)
            {
                speed = 50;
            }
        }
    }
}
