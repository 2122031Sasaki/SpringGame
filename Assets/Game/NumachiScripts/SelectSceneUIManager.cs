using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SelectSceneUIManager : MonoBehaviour
{
    Vector3 minScale = new Vector3(1f, 1.5f, 1);
    Vector3 maxScale = new Vector3(1.07f, 1.6f, 1);

    //ボタンのscaleを拡大する関数
    public void PointerEnter(GameObject button)
    {
        button.transform.DOScale(maxScale, 0.3f);
    }

    //ボタンのscaleを縮小させる関数
    public void PointerExit(GameObject button)
    {
        button.transform.DOScale(minScale, 0.3f);
    }
}
