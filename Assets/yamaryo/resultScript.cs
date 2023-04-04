using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultScript : MonoBehaviour
{
    public Text resulttimeText;

    public Text besttimeText;

    float time;

    float besttime;

    // Start is called before the first frame update
    void Start()
    {
        time = timeScript.gettime();
        resulttimeText.text = "Time:" + time.ToString("F2");

        besttime = PlayerPrefs.GetFloat("BESTTIME01", 1000);
       
    }

    // Update is called once per frame
    void Update()
    {
        besttimeText.text = "Best Time:" + besttime.ToString("F2");

        if (besttime > time)
        {
            besttime = time;
            PlayerPrefs.SetFloat("BESTTIME01", besttime);
            PlayerPrefs.Save();
        }
    }

    

}
