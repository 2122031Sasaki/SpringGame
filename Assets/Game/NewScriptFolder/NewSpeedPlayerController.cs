using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NewSpeedPlayerController : MonoBehaviour
{
    public Rigidbody rb;
    private float Speed;
    private float Turn;
    private float Brake;
    private float DownSpeed;
    private float SpeedUpTime;
    private float miniSpeedUpTime;
    private float MaxSpeed;
    private float LowSpeed;
    private float Jump;
    private bool Jumpable;
    private float Key;

    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>(); 
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Speed = -10.0f;
        Turn = 0.425f;
        DownSpeed = 1.0f;
        Brake = 5.0f;
        SpeedUpTime = 3.0f;
        miniSpeedUpTime = 2.0f;
        MaxSpeed = 20.0f;
        LowSpeed = -5.0f;
        Jump = 100.0f;
        Jumpable = false;
        Key = 1.0f;
        Application.targetFrameRate = 120;
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        if (pos.x < 1018.0f && pos.x > 1000.0f && pos.y > 542.0)
        {
            pos.x -= 0.05f;
        }
        myTransform.position = pos;

        GetComponent<Rigidbody>().AddForce(transform.forward * Speed * Key, ForceMode.Force);

        if (Input.GetKey(KeyCode.W))
        {
             GetComponent<Rigidbody>().AddForce(transform.forward * Speed * Key, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -Turn, 0);
            GetComponent<Rigidbody>().AddForce(transform.forward * DownSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, Turn, 0);
            GetComponent<Rigidbody>().AddForce(transform.forward * DownSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * Brake, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.Space) && Jumpable)
        {
            Vector3 force = new Vector3(0.0f, Jump, 0.0f);
            rb.AddForce(force);
        }
        float speedx = Mathf.Abs(rb.velocity.x);
        float speedy = Mathf.Abs(rb.velocity.y);
        float speedz = Mathf.Abs(rb.velocity.z);
        if (speedx > MaxSpeed || speedy > MaxSpeed || speedz > MaxSpeed)
        {
            Key = 0.0f;
        }
        else if (speedx < LowSpeed || speedy < LowSpeed || speedz < LowSpeed)
        {
            Key = 0.5f;
        }
        else
        {
            Key = 1.0f;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Jumpable = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        Jumpable = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pole")
        {
            StartCoroutine("SpeedUp");
            MaxSpeed += 0.05f;
        }
        if (other.gameObject.tag == "miniPole")
        {
            StartCoroutine("miniSpeedUp");
            MaxSpeed += 0.05f;
        }
    }

    IEnumerator SpeedUp()
    {
        Speed = Speed * 1.15f;
        yield return new WaitForSeconds(SpeedUpTime);
        Speed = -10.5f;
    }

    IEnumerator miniSpeedUp()
    {
        Speed = Speed * 1.10f;
        yield return new WaitForSeconds(miniSpeedUpTime);
        Speed = -10.5f;
    }
}
