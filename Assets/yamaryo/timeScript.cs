using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeScript : MonoBehaviour
{
    public static float time;

    

    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        timeText.text = "Time:" + time.ToString("F2");
    }

    public static float gettime()
    {
        return time;
    }

}
