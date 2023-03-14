using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed;
    public bool isTouched;
    public float time;
    public GameObject destroyObj;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
        isTouched = false;
        time = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, 0f, speed * -1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed * -1, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0f, 0f);
        }

        if (isTouched)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                Destroy(destroyObj);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            StartCoroutine("SpeedUp");
            destroyObj = other.gameObject;
            isTouched = true;
        }
    }

    IEnumerator SpeedUp()
    {
        speed = 0.1f;
        yield return new WaitForSeconds(3.0f);
        speed = 0.01f;
    }
}
