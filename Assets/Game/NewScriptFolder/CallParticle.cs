using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallParticle : MonoBehaviour
{
    bool call;
    public GameObject getparticle;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        call = false;
    }

    // Update is called once per frame
    void Update()
    {
        // transformを取得
        Transform myTransform = this.transform;

        // 座標を取得
        Vector3 pos = myTransform.localScale;
        if (call == true)
        {
            obj = Instantiate(getparticle, this.transform.position, Quaternion.Euler(0, 90, 0));
            obj.transform.localScale = new Vector3(pos.x * 2.75f, pos.y * 2.75f, pos.z * 2.75f);
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
