using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall_script : MonoBehaviour
{
    GameObject beforePos1;

    // Start is called before the first frame update
    void Start()
    {
        this.beforePos1 = GameObject.Find("beforePos1");
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
            Vector3 pos = this.beforePos1.transform.position;
            pos.y += 5.0f;
            gameObject.transform.position = pos;
        }
    }
}
