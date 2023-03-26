using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    bool Rha;
    bool Rha2;
    void Start()
    {
        Rha = true;
        Rha2 = true;
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
        if (localAngle.x < 0 && Rha == true)
        {
            localAngle.x += 0.05f;
        }
        if (localAngle.x < -20 && Rha == false)
        {
            localAngle.x += 0.0025f;
        }

        if (localAngle.x < -10 && Rha2 == true)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < -20 && Rha2 == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < -10 && Rha2 == false)
        {
            localAngle.x += 0.00125f;
        }

        localAngle.z = 0.0f;
        myTransform.localEulerAngles = localAngle; // 回転角度を設定

        if (localAngle.x >= -20 && Rha == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
        }
        if (localAngle.x >= -15 && Rha2 == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationY;
        }
        if (Rha == false)
        {
            Physics.gravity = new Vector3(0, -15, 0);
        }
        if (Rha2 == false)
        {
            Physics.gravity = new Vector3(0, -18, 0);
        }
        if (Rha == true && Rha2 == true)
        {
            Physics.gravity = new Vector3(0, -10, 0);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "RotetaController")
        {
            Rha = false;
            Debug.Log("a");
        }
        if (other.gameObject.name == "RotetaController2")
        {
            Rha2 = false;
            Debug.Log("c");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "RotetaController")
        {
            Rha = true;
            Debug.Log("b");
        }
        if (other.gameObject.name == "RotetaController2")
        {
            Rha2 = true;
            Debug.Log("d");
        }
    }
}
