using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProperty : MonoBehaviour
{
    private int value;
    public GameObject [] tireStack;

    private void Start()
    {
        value = Random.Range(0, 3);

        for(int i = 0; i < tireStack.Length; i++)
        {
            tireStack[i].SetActive(false);
        }

        tireStack[value].SetActive(true);
    }



    // OnBecameInvisible <- ī�޶� ���ߴ� ȭ�� ������ �̺�Ʈ�� �ߵ��ϴ� �Լ��Դϴ�.
    // MeshRender�� �ʿ��մϴ�.
    

}
