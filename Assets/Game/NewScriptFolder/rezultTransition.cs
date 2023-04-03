using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rezultTransition : MonoBehaviour
{
    private bool Clear1;
    private bool Clear2;

    private void Start()
    {
        Clear1 = false;
        Clear2 = false;
    }

    private void Update()
    {
        if (Clear1 == true)
        {
            SceneManager.LoadScene("NewResultScene");
        }

        if (Clear2 == true)
        {
            SceneManager.LoadScene("NewResultScene2");
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