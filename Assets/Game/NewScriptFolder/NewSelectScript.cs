using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewSelectScript : MonoBehaviour
{
    //”Ô†‚Å‘Î‰‚³‚¹‚é
    int selectCharaNumber;

    void Start()
    {
        //‚Í‚¶‚ß‚Í0
        selectCharaNumber = 0;
    }

    public void OnClickA()
    {
        //¶‚ğ‘I‘ğ‚µ‚½‚ç1
        selectCharaNumber = 0;
    }
    public void OnClickB()
    {
        //“ñ‹U‚ğ‘I‘ğ‚µ‚½‚ç1
        selectCharaNumber = 1;
    }


    public void OnClickStart()
    {
        //”Ô†‚ğ‹L‰¯‚³‚¹‚é
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
        SceneManager.LoadScene("NewGameScene");
    }
}
