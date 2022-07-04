using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public float speed;
    public GameObject road;

    List<GameObject> roadList;

    int firstRoad;
    int lastRoad;

    Vector3 nextRoad = Vector3.zero;

    void Start()
    {
        roadList = new List<GameObject>();

        for(int i = 0; i < 5; i++)
        {
            roadList.Add(Instantiate(road, nextRoad, Quaternion.identity));
            nextRoad += Vector3.forward * 20;
        }
        
    }

    void Update()
    {
        for(int i = 0; i < roadList.Count; i++)
        {
            roadList[i].transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (roadList[lastRoad].transform.position.z <= -20)
        {
            // -1   <      0 - 1
            firstRoad = lastRoad - 1;

            if (firstRoad < 0)
            {
                // 4     <-        5 - 1
                firstRoad = roadList.Count - 1;
            }
            roadList[lastRoad].transform.position = roadList[firstRoad].transform.position + Vector3.forward * 20;

            lastRoad++;

            if (lastRoad >= roadList.Count)
            {
                lastRoad = 0;
            }
        }
    }
}
