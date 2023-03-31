using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallParticle : MonoBehaviour
{
    bool call;
    public GameObject getparticle;
    // Start is called before the first frame update
    void Start()
    {
        call = false;
    }

    // Update is called once per frame
    void Update()
    {
        // transform���擾
        Transform myTransform = this.transform;

        // ���W���擾
        Vector3 pos = myTransform.position;
        if (call == true)
        {
            Instantiate(getparticle, this.transform.position, Quaternion.Euler(0, 90, 0));
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
