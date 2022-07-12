using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAnimater : MonoBehaviour
{
    public Animator animator;
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character")
        {
            animator.enabled = true;
        }
    }
}
