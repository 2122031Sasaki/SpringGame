using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeScript : MonoBehaviour
{
    public static float time;
    //�k�}�`���񂪑������Ƃ���
    public float scoreTime;

    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        scoreTime = time;

        timeText.text = "" + time.ToString("F2");
    }

    public static float gettime()
    {
        return time;
    }

    public float Addtime()
    {
        time = time + 5f;
        return time;
    }

}
