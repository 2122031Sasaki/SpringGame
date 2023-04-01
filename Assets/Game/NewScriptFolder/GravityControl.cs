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
        // transformÇéÊìæ
        Transform myTransform = this.transform;

        // ÉçÅ[ÉJÉãç¿ïWÇäÓèÄÇ…ÅAâÒì]ÇéÊìæ
        Vector3 localAngle = myTransform.localEulerAngles;
        // åªç›ÇÃäpìxÇ™180ÇÊÇËëÂÇ´Ç¢èÍçá
        if (localAngle.x > 180)
        {
            // ÉfÉtÉHÉãÉgÇ≈ÇÕäpìxÇÕ0Å`360Ç»ÇÃÇ≈-180Å`180Ç∆Ç»ÇÈÇÊÇ§Ç…ï‚ê≥
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
        myTransform.localEulerAngles = localAngle; // âÒì]äpìxÇê›íË

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
        if (other.gameObject.name == "RotetaController4")
        {
            Rha4 = false;
            Debug.Log("g");
        }
        if (other.gameObject.name == "RotetaController5")
        {
            Rha5 = false;
            Debug.Log("i");
        }
        if (other.gameObject.name == "GravityController")
        {
            Rha6 = false;
            Debug.Log("E");
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
        if (other.gameObject.name == "RotetaController4")
        {
            Rha4 = true;
            Debug.Log("h");
        }
        if (other.gameObject.name == "RotetaController5")
        {
            Rha5 = true;
            Debug.Log("j");
        }
        if (other.gameObject.name == "GravityController")
        {
            Rha6 = true;
            Debug.Log("F");
        }
    }
}
