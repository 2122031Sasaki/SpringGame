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


    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody���擾
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Speed = 1.5f;
        Turn = 1.0f;
        Brake = -0.5f;
        DownSpeed = -10.0f;
        SpeedUpTime = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //���������Ă��������O�Ƃ��āAAddForce�Ŗ��t���[�������������������Ă���
        GetComponent<Rigidbody>().AddForce(transform.forward * -4.0f, ForceMode.Force);

        if (Input.GetKey(KeyCode.W))//W�ŉ���
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * -Speed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A))//A�ŉE�ɋȂ���,Turn�̎��Ɛ��l�͗v����,Break��TurnPlayer�ɔ�׏d�߂ɐݒ�
        {
            transform.Rotate(0, -Turn, 0);
            GetComponent<Rigidbody>().AddForce(transform.forward * -Brake, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))//D�ō��ɋȂ���,Turn�̎��Ɛ��l�͗v����,Break��TurnPlayer�ɔ�׏d�߂ɐݒ�
        {
            transform.Rotate(0, Turn, 0);
            GetComponent<Rigidbody>().AddForce(transform.forward * -Brake, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))//S�Ńu���[�L,�}�������ł���悤���߂ɐݒ�
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * -DownSpeed, ForceMode.Force);
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
