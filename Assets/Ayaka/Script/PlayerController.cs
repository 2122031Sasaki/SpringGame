using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("tfall_2itfall_2"))
        {
            SceneManager.LoadScene("NewResultScene");
        }

        if (other.gameObject.CompareTag("Cube.025"))
        {
            SceneManager.LoadScene("NewResultScene2");
        }
    }
}
