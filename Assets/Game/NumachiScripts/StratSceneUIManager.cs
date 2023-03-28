using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class StratSceneUIManager : MonoBehaviour
{
    Vector3 minScale = new Vector3(1f, 1.5f, 1);
    Vector3 maxScale = new Vector3(1.07f, 1.6f, 1);

    //�{�^����scale���g�傷��֐�
    public void PointerEnter(GameObject button)
    {
        button.transform.DOScale(maxScale, 0.3f);
    }

    //�{�^����scale���k��������֐�
    public void PointerExit(GameObject button)
    {
        button.transform.DOScale(minScale, 0.3f);
    }

    //�V�[���J�ڊ֐�(������string�^�ŃV�[���������)
    public void ScaenTransition(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    //�Q�[�����I��������֐�
    public void EndGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
