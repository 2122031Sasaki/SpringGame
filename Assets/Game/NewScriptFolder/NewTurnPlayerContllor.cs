using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTurnPlayerContllor : MonoBehaviour
{
    public Rigidbody rb;
    private float Speed;
    private float Turn;
    private float Brake;
    private float DownSpeed;
    private float SpeedUpTime;
    private float MaxSpeed;
    private float Key;


    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Speed = -15.0f;
        Turn = 1.0f;
        Brake = 5.0f;
        DownSpeed = 0.5f;
        SpeedUpTime = 3.0f;
        MaxSpeed = 15.0f;
        Key = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //青軸が向いている方向を前として、AddForceで毎フレームずつ慣性をかけ続けている
        GetComponent<Rigidbody>().AddForce(transform.forward * Speed * Key, ForceMode.Force);

        /*
        if (Input.GetKey(KeyCode.W))//Wで加速
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * -Speed, ForceMode.Force);
        }
        */

        if (Input.GetKey(KeyCode.A))//Aで右に曲がる,Turnの軸と数値は要調整,BreakはTurnPlayerに比べ重めに設定
        {
            transform.Rotate(0, -Turn, 0);
            GetComponent<Rigidbody>().AddForce(transform.forward * DownSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))//Dで左に曲がる,Turnの軸と数値は要調整,BreakはTurnPlayerに比べ重めに設定
        {
            transform.Rotate(0, Turn, 0);
            GetComponent<Rigidbody>().AddForce(transform.forward * DownSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))//Sでブレーキ,急制動ができるよう強めに設定
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
        else
        {
            Key = 1.0f;
        }
        float currentXAngle = transform.eulerAngles.x;
        // 現在の角度が180より大きい場合
        if (currentXAngle > 180)
        {
            // デフォルトでは角度は0～360なので-180～180となるように補正
            currentXAngle = currentXAngle - 360;
        }
        if (currentXAngle < -20)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
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
