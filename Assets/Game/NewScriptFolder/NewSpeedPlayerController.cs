using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpeedPlayerController : MonoBehaviour
{
    public Rigidbody rb;
    private float Speed;
    private float Turn;
    private float Brake;
    private float DownSpeed;
    private float SpeedUpTime;
    private float MaxSpeed;
    private float LowSpeed;
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
        Turn = 0.5f;
        DownSpeed = 1.0f;
        Brake = 5.0f;
        SpeedUpTime = 3.0f;
        MaxSpeed = 20.0f;
        LowSpeed = -5.0f;
        Key = 1.0f;
        Application.targetFrameRate = 120;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * Speed * Key, ForceMode.Force);

        
        if (Input.GetKey(KeyCode.W) == true)
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
        float speedx = Mathf.Abs(rb.velocity.x);
        float speedy = Mathf.Abs(rb.velocity.y);
        float speedz = Mathf.Abs(rb.velocity.z);
        if (speedx > MaxSpeed || speedy > MaxSpeed || speedz > MaxSpeed)
        {
            Key = 0.0f;
        }
        else if (speedx < LowSpeed || speedy < LowSpeed || speedz < LowSpeed)
        {
            Key = 0.0f;
        }
        else
        {
            Key = 1.0f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SpeedUpBoard" || other.gameObject.name == "SpeedUpWall")
        {
            StartCoroutine("SpeedUp");
        }
    }

    IEnumerator SpeedUp()
    {
        Speed = Speed * 1.5f;
        yield return new WaitForSeconds(SpeedUpTime);
        Speed = 3.0f;
    }
}
