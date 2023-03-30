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
    private float LowSpeed;
    private float Key;

    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody���擾
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Speed = -11.0f;
        Turn = 0.925f;
        DownSpeed = 0.01f;
        Brake = 5.0f;
        SpeedUpTime = 3.0f;
        MaxSpeed = 15.0f;
        LowSpeed = -5.0f;
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
        //���������Ă��������O�Ƃ��āAAddForce�Ŗ��t���[�������������������Ă���
        GetComponent<Rigidbody>().AddForce(transform.forward * Speed * Key, ForceMode.Force);

        if (Input.GetKey(KeyCode.W))//W�ŉ���
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * Speed * Key, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A))//A�ŉE�ɋȂ���,Turn�̎��Ɛ��l�͗v����,Break��TurnPlayer�ɔ�׏d�߂ɐݒ�
        {
            transform.Rotate(0, -Turn, 0);
            GetComponent<Rigidbody>().AddForce(transform.forward * DownSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))//D�ō��ɋȂ���,Turn�̎��Ɛ��l�͗v����,Break��TurnPlayer�ɔ�׏d�߂ɐݒ�
        {
            transform.Rotate(0, Turn, 0);
            GetComponent<Rigidbody>().AddForce(transform.forward * DownSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))//S�Ńu���[�L,�}�������ł���悤���߂ɐݒ�
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
            Key = 0.5f;
        }
        else
        {
            Key = 1.0f;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Pole")
        {
            StartCoroutine("SpeedUp");
            Debug.Log("A");
        }
    }

    IEnumerator SpeedUp()
    {
        Speed = Speed * 1.5f;
        yield return new WaitForSeconds(SpeedUpTime);
        Speed = 3.0f;
        Debug.Log("B");
    }
}
