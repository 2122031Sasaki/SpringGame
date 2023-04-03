using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public timeScript Cleartime;
    float Score;

    private void Start()
    {
        Score = PlayerPrefs.GetFloat("SCORE");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("tfall_2itfall_2"))
        {
            Score = Cleartime.time;
            PlayerPrefs.SetFloat("SCORE", Score);
            SceneManager.LoadScene("NewResultScene");
        }

        if (other.gameObject.CompareTag("Cube.025"))
        {
            SceneManager.LoadScene("NewResultScene2");
        }
    }
}
