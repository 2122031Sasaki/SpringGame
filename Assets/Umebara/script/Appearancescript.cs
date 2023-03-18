using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appearancescript : MonoBehaviour
{
    int selectCharaNumber;
    public GameObject Player_speed;
    public GameObject Player_turn;
    void Start()
    {
        selectCharaNumber= PlayerPrefs.GetInt("CHARA_NUMBER", 0);
        Debug.Log(selectCharaNumber);
        if (selectCharaNumber == 0)
        {
            Instantiate(Player_speed, new Vector3(16.0f, 22.0f, 43.0f), Quaternion.identity);
        }
        if(selectCharaNumber == 1)
        {
            Instantiate(Player_turn, new Vector3(16.0f, 22.0f, 43.0f), Quaternion.identity);
        }
        PlayerPrefs.DeleteKey("CHARA_NUMBER");

    }

    void Update()
    {
        
    }
}
