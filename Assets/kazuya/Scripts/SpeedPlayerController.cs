using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPlayerController : MonoBehaviour
{
    public Rigidbody rb;
    Rigidbody rigid;
    Vector3 Speed;
    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 force = new Vector3(-10.0f, 0.0f, 0.0f);    // 力を設定
        rb.AddForce(force);  // 力を加える
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0.0f, 0.0f, 0.0f);    // vector3を作成
       rigid = GameObject.Find("SpeedPlayer").GetComponent<Rigidbody>(); //スピードを計測
    }

    // Update is called once per frame
    void Update()
    {
        Speed = rigid.velocity;
        Debug.Log(Speed);
        //右に動かすプログラム
        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.Translate(new Vector3(0, 0, -0.03f));
            Vector3 force = new Vector3(2.0f, 0.0f, 0.0f);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
        //左に動かすプログラム
        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.Translate(new Vector3(0, 0, 0.03f));
            Vector3 force = new Vector3(2.0f, 0.0f, 0.0f);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
        //ブレーキをかけるプログラム
        if(Input.GetKey(KeyCode.S) == true)
        {
            Vector3 force = new Vector3(5.0f, 0.0f, 0.0f);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
        //加速するプログラム
        if(Input.GetKey(KeyCode.W) == true)
        {
            Vector3 force = new Vector3(-3.0f, 0.0f, 0.0f);    // 力を設定
            rb.AddForce(force);  // 力を加える
        }
      
    }
}
