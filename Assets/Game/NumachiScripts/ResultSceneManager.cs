using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ResultSceneManager : MonoBehaviour
{
    int characterNum;

    public GameObject player_red;
    public GameObject player_blue;
    void Start()
    {
        characterNum = PlayerPrefs.GetInt("CHARA_NUMBER");
        ShowCharacter();
    }

    void ShowCharacter()
    {
        if(characterNum == 0)
        {
            player_red.SetActive(true);
        }
        else if(characterNum == 1)
        {
            player_blue.SetActive(true);
        }
    }
    Vector2 currentScale;
    public void PointerEnter(GameObject button)
    {
        currentScale = button.transform.localScale;
        button.transform.DOScale(currentScale * 1.1f, 0.3f);
    } 
    public void PointerExit(GameObject button)
    {
        button.transform.DOScale(currentScale,0.3f);
    }
}
