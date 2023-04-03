using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restrat : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnRestart()
    {
        SceneManager.LoadScene("NumachiScene");
    }

    public void OnTitle()
    {
        SceneManager.LoadScene("NewStartScene");
    }

}
