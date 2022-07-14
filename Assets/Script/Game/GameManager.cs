using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager 게임 전반적인 내용저장
    // static : 프로그램이 종료될 때까지 메모리에서 살아있습니다.
    // 데이터 영역에 저장됩니다.
    public static GameManager instance;

    public float speed;
    public bool state;
    public int coin;

    void Start()
    {
        Load();

        if (instance == null)
        {
            instance = this;
        }

        state = true;

    }

    public void Save()
    {
        PlayerPrefs.SetInt("Coin", coin);
    }

    public void Load()
    {
        coin = PlayerPrefs.GetInt("Coin");
    }


}
