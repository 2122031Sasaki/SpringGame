using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallParticle90 : MonoBehaviour
{
    bool call;
    public GameObject getparticle90;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        call = false;
    }

    // Update is called once per frame
    void Update()
    {
        // transformÇéÊìæ
        Transform myTransform = this.transform;

        // ç¿ïWÇéÊìæ
        Vector3 pos = myTransform.localScale;
        if (call == true)
        {
            obj = Instantiate(getparticle90, this.transform.position, Quaternion.Euler(0, 0, 0));
            obj.transform.localScale = new Vector3(pos.x * 2.75f, 2.5f, pos.z * 2.75f);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            call = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            call = false;
        }
    }
}
