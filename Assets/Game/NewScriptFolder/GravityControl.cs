using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    bool Rha;
    bool Rha2;
    bool Rha3;
    bool Rha4;
    bool Rha5;
    bool Rha6;
    void Start()
    {
        Rha = true;
        Rha2 = true;
        Rha3 = true;
        Rha4 = true;
        Rha5 = true;
        Rha6 = true;
    }

    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // transformを取得
        Transform myTransform = this.transform;

        // ローカル座標を基準に、回転を取得
        Vector3 localAngle = myTransform.localEulerAngles;
        // 現在の角度が180より大きい場合
        if (localAngle.x > 180)
        {
            // デフォルトでは角度は0〜360なので-180〜180となるように補正
            localAngle.x = localAngle.x - 360;
        }


        if (localAngle.x < -20 && Rha == true)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < -30 && Rha == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < 0 && Rha == true && Rha2 ==true && Rha3 == true && Rha4 == true && Rha5 == true)
        {
            localAngle.x += 0.15f;
        }

        if (localAngle.x < -10 && Rha2 == true)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < -20 && Rha2 == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }

        if (localAngle.x < -20 && Rha3 == true)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < -30 && Rha3 == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }

        if (localAngle.x < -20 && Rha4 == true)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < -30 && Rha4 == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }

        if (localAngle.x < -15 && Rha5 == true)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < -25 && Rha5 == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }

        localAngle.z = 0.0f;
        myTransform.localEulerAngles = localAngle; // 回転角度を設定

        if (localAngle.x >= -20 && Rha == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
        }
        if (localAngle.x >= -10 && Rha2 == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
        }
        if (localAngle.x >= -20 && Rha3 == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
        }
        if (localAngle.x >= -20 && Rha4 == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
        }
        if (localAngle.x >= -15 && Rha5 == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
        }

        if (Rha == false)
        {
            Physics.gravity = new Vector3(0, -16, 0);
            GetComponent<Rigidbody>().mass = 8.0f;
        }
        if (Rha2 == false)
        {
            Physics.gravity = new Vector3(0, -19, 0);
        }
        if (Rha3 == false)
        {
            Physics.gravity = new Vector3(0, -16, 0);
            GetComponent<Rigidbody>().mass = 8.0f;
        }
        if (Rha4 == false)
        {
            Physics.gravity = new Vector3(0, -15, 0);
        }
        if (Rha5 == false)
        {
            Physics.gravity = new Vector3(0, -15, 0);
        }
        if (Rha6 == false)
        {
            Physics.gravity = new Vector3(0, -15, 0);
        }

        if (Rha == true && Rha4 == true && Rha3 == true && Rha4 == true && Rha5 == true && Rha6 == true)
        {
            Physics.gravity = new Vector3(0, -10, 0);
            GetComponent<Rigidbody>().mass = 3.4f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RotetaController")
        {
            Rha = false;
        }
        if (other.gameObject.name == "RotetaController2")
        {
            Rha2 = false;
        }
        if (other.gameObject.name == "RotetaController3")
        {
            Rha3 = false;
        }
        if (other.gameObject.name == "RotetaController4")
        {
            Rha4 = false;
        }
        if (other.gameObject.name == "RotetaController5")
        {
            Rha5 = false;
        }
        if (other.gameObject.name == "GravityController")
        {
            Rha6 = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "RotetaController")
        {
            Rha = true;
        }
        if (other.gameObject.name == "RotetaController2")
        {
            Rha2 = true;
        }
        if (other.gameObject.name == "RotetaController3")
        {
            Rha3 = true;
        }
        if (other.gameObject.name == "RotetaController4")
        {
            Rha4 = true;
        }
        if (other.gameObject.name == "RotetaController5")
        {
            Rha5 = true;
        }
        if (other.gameObject.name == "GravityController")
        {
            Rha6 = true;
        }
    }
}
