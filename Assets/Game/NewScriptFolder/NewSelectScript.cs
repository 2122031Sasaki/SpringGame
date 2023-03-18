using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewSelectScript : MonoBehaviour
{
    //�ԍ��őΉ�������
    int selectCharaNumber;

    void Start()
    {
        //�͂��߂�0
        selectCharaNumber = 0;
    }

    public void OnClickA()
    {
        //����I��������1
        selectCharaNumber = 0;
    }
    public void OnClickB()
    {
        //��U��I��������1
        selectCharaNumber = 1;
    }


    public void OnClickStart()
    {
        //�ԍ����L��������
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
        SceneManager.LoadScene("NewGameScene");
    }
}
