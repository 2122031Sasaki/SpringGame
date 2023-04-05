using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Ball;

public class DestroyParticle : MonoBehaviour
{
    bool CallIce;
    bool CallSnow;
    bool Callstar;
    public GameObject getIce;
    public GameObject getSnow;
    public GameObject getstar; 
    GameObject objIce;
    GameObject objSnow;
    GameObject objStar;
    // Start is called before the first frame update
    void Start()
    {
        CallIce = false;
        CallSnow= false;
        Callstar = false;
    }

    // Update is called once per frame
    void Update()
    {
        // transform‚ðŽæ“¾
        Transform myTransform = this.transform;

        if (CallIce == true)
        {
            objIce = Instantiate(getIce, this.transform.position, Quaternion.identity);
            CallIce= false;
        }

        if (CallSnow == true)
        {
            objSnow = Instantiate(getSnow, this.transform.position, Quaternion.identity);
            CallSnow= false;
        }
        if (Callstar == true)
        {
            objStar = Instantiate(getstar, this.transform.position, Quaternion.identity);
            Callstar = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DestroySnow")
        {
            CallSnow = true;
        }
        if (other.gameObject.tag == "DestroyIce")
        {
            CallIce = true;
        }
        if (other.gameObject.tag == "DestroyStar")
        {
            Callstar = true;
        }
    }
}
