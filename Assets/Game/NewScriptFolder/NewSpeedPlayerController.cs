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
    private float Key;
    bool Rha;

    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody���擾
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
        Key = 1.0f;
        Rha = true;
    }

    // Update is called once per frame
    void Update()
    {
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
        else
        {
            Key = 1.0f;
        }


        // transformを取得
        Transform myTransform = this.transform;

        // ローカル座標を基準に、回転を取得
        Vector3 localAngle = myTransform.localEulerAngles;
        // 現在の角度が180より大きい場合
        if (localAngle.x > 180)
        {
            // デフォルトでは角度は0～360なので-180～180となるように補正
            localAngle.x = localAngle.x - 360;
        }
        if (localAngle.x < -20 && Rha == true)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < -45 && Rha == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < 0 && Rha == true)
        {
            localAngle.x += 0.05f;
        }
        if (localAngle.x < -20 && Rha == false)
        {
            localAngle.x += 0.0025f;
        }

        localAngle.z = 0.0f;
        myTransform.localEulerAngles = localAngle; // 回転角度を設定
  
        if (localAngle.x >= -20 && Rha == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
        }
        if (Rha == false)
        {
            Physics.gravity = new Vector3(0, -20, 0);
        }
        if (Rha == true)
        {
            Physics.gravity = new Vector3(0, -10, 0);
        }


    }
    //���肳�񂩂璸���������p�̃X�N���v�g
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SpeedUpBoard" || other.gameObject.name == "SpeedUpWall")
        {
            StartCoroutine("SpeedUp");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "RotetaController")
        {
            Rha = false;
            Debug.Log("a");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "RotetaController")
        {
            Rha = true;
            Debug.Log("b");
        }
    }

    IEnumerator SpeedUp()
    {
        Speed = Speed * 1.5f;
        yield return new WaitForSeconds(SpeedUpTime);
        Speed = 3.0f;
    }
}
