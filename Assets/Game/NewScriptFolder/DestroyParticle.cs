using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Ball;
using static UnityEditor.PlayerSettings;

public class DestroyParticle : MonoBehaviour
{
    bool CallIce;
    bool CallSnow;
    public GameObject getIce;
    public GameObject getSnow;
    GameObject objIce;
    GameObject objSnow;
    // Start is called before the first frame update
    void Start()
    {
        CallIce = false;
        CallSnow= false;
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
    }
}
