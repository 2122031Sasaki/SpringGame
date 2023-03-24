using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewExplanationSceneTransition : MonoBehaviour
{
    public void OnExplanationButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
