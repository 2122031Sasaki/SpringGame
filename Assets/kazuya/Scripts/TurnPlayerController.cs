using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPlayerController : MonoBehaviour
{
    public Rigidbody rb;
    Rigidbody rigid;
    Vector3 Speed;
    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody���擾
        Vector3 force = new Vector3(-10.0f, 0.0f, 0.0f);    // �͂�ݒ�
        rb.AddForce(force);  // �͂�������
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0.0f, 0.0f, 0.0f);    // vector3���쐬
        rigid = GameObject.Find("SpeedPlayer").GetComponent<Rigidbody>(); //�X�s�[�h���v��
    }

    // Update is called once per frame
    void Update()
    {
        Speed = rigid.velocity;
        Debug.Log(Speed);
        //�E�ɓ������v���O����
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(new Vector3(0, 0, -0.05f));
            Vector3 force = new Vector3(1.5f, 0.0f, 0.0f);    // �͂�ݒ�
            rb.AddForce(force);  // �͂�������
        }
        //���ɓ������v���O����
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(new Vector3(0, 0, 0.05f));
            Vector3 force = new Vector3(1.5f, 0.0f, 0.0f);    // �͂�ݒ�
            rb.AddForce(force);  // �͂�������
        }
        //�u���[�L��������v���O����
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            Vector3 force = new Vector3(5.0f, 0.0f, 0.0f);    // �͂�ݒ�
            rb.AddForce(force);  // �͂�������
        }
        //��������v���O����
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            Vector3 force = new Vector3(-2.0f, 0.0f, 0.0f);    // �͂�ݒ�
            rb.AddForce(force);  // �͂�������
        }

    }
}

