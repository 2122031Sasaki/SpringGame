using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public static float time;

    public bool isTouched;
    public bool mutekiTouched;
    public bool tf;
    public GameObject destroyObj;

    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        isTouched = false;
        mutekiTouched = false;
        tf = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        timeText.text = "Time:" + time.ToString("F2");

        if (isTouched)
        {
            Destroy(destroyObj);
            time += 5;
            isTouched = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            StartCoroutine("Muteki");
            destroyObj = other.gameObject;
            mutekiTouched = true;
            Destroy(destroyObj);
        }

        if (other.gameObject.name == "Cylinder")
        {
            destroyObj = other.gameObject;
            if (tf == false)
            {
                isTouched = true;
            }

        }
    }

    public static float gettime()
    {
        return time;
    }

    IEnumerator Muteki()
    {
        tf = true;
        yield return new WaitForSeconds(10.0f);
        tf = false;
    }
}
