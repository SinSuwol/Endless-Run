using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProperty : MonoBehaviour
{
    private int value;
    public GameObject [] tireStack;
    public Animator[] animator;
    private void Start()
    {
        value = Random.Range(0, 3);

        for(int i = 0; i < tireStack.Length; i++)
        {
            tireStack[i].SetActive(false);
        }

        tireStack[value].SetActive(true);
    }

    void Update()
    {
        if (GameManager.instance.state == false) return;

        transform.Translate(Vector3.back * GameManager.instance.speed * Time.deltaTime);

        if(transform.position.z <= -10f)
        {
            Destroy(gameObject);
        }
    }

    // OnBecameInvisible <- 카메라가 비추는 화면 밖으로 이벤트를 발동하는 함수입니다.
    // MeshRender가 필요합니다.
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Character")
        {
            animator[value].enabled = true;
        }
    }

}
