using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall_script : MonoBehaviour
{
    GameObject beforePos1;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        this.beforePos1 = GameObject.Find("beforePos1");
        this.rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 落下判定＆コースへの再配置
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "fallJudge1")
        {
            this.rb.isKinematic = true;
            Vector3 pos = this.beforePos1.transform.position;
            pos.y += 5.0f;
            gameObject.transform.position = pos;
            this.rb.isKinematic = false;
        }
    }
}
