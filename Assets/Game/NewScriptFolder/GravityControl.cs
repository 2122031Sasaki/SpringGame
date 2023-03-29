using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    bool Rha;
    bool Rha2;
    bool Rha3;
    void Start()
    {
        Rha = true;
        Rha2 = true;
        Rha3 = true;
    }

    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // transform���擾
        Transform myTransform = this.transform;

        // ���[�J�����W����ɁA��]���擾
        Vector3 localAngle = myTransform.localEulerAngles;
        // ���݂̊p�x��180���傫���ꍇ
        if (localAngle.x > 180)
        {
            // �f�t�H���g�ł͊p�x��0�`360�Ȃ̂�-180�`180�ƂȂ�悤�ɕ␳
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
            localAngle.x += 0.00125f;
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

        if (localAngle.x < 0 && Rha == true)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < -30 && Rha3 == false)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (localAngle.x < 0 && Rha3 == true)
        {
            localAngle.x += 0.05f;
        }
        if (localAngle.x < -20 && Rha3 == false)
        {
            localAngle.x += 0.00125f;
        }

        localAngle.z = 0.0f;
        myTransform.localEulerAngles = localAngle; // ��]�p�x��ݒ�

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
        if (localAngle.x >= -20 && Rha3 == false)
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
        if (Rha3 == false)
        {
            Physics.gravity = new Vector3(0, -15, 0);
        }

        if (Rha == true && Rha2 == true || Rha3 == true)
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
        if (other.gameObject.name == "RotetaController3")
        {
            Rha3 = false;
            Debug.Log("e");
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
        if (other.gameObject.name == "RotetaController3")
        {
            Rha3 = true;
            Debug.Log("f");
        }
    }
}
