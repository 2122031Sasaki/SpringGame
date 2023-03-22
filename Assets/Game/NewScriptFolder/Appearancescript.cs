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
            Instantiate(Player_speed, new Vector3(1010.0f, 560f, 1502.0f), Quaternion.Euler(0, 90.0f, 0));
        }
        if(selectCharaNumber == 1)
        {
            Instantiate(Player_turn, new Vector3(1010.0f, 546f, 1502.0f), Quaternion.Euler(0, 0.0f, 0));
        }
        PlayerPrefs.DeleteKey("CHARA_NUMBER");

    }

    void Update()
    {
        
    }
}
