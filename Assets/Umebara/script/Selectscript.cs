using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selectscript : MonoBehaviour
{
    //番号で対応させる
    int selectCharaNumber;

    void Start()
    {
        //はじめは0
        selectCharaNumber = 0;
    }

    public void OnClickA()
    {
        //左を選択したら1
        selectCharaNumber = 0;
    }
    public void OnClickB()
    {
        //二偽を選択したら1
        selectCharaNumber = 1;
    }


    public void OnClickStart()
    {
        //番号を記憶させる
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
        SceneManager.LoadScene("Ustart");
    }
}
