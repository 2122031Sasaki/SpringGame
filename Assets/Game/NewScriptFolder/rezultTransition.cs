using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rezultTransition : MonoBehaviour
{
    private bool Clear1;
    private bool Clear2;
    public GameObject GameManeger;
    float Score;

    private void Start()
    {
        Clear1 = false;
        Clear2 = false;
        Score = PlayerPrefs.GetFloat("SCORE");
    }

    private void Update()
    {
        if (Clear1 == true)
        {
            SceneManager.LoadScene("NewResultScene");
            Score = GameManeger.GetComponent<timeScript>().scoreTime;
            PlayerPrefs.SetFloat("SCORE", Score);
        }

        if (Clear2 == true)
        {
            SceneManager.LoadScene("NewResultScene2");
            Score = GameManeger.GetComponent<timeScript>().scoreTime;
            PlayerPrefs.SetFloat("SCORE", Score);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tfall_2itfall_2")
        {
            Clear1 = true;
        }

        if (other.gameObject.tag == "Cube.025")
        {
            Clear2 = true;
        }
    }
}