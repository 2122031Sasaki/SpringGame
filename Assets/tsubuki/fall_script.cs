using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Transform myTransform = this.gameObject.GetComponent<Transform>();
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �������聕�R�[�X�ւ̍Ĕz�u
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "beforePos")
        {
            pos = myTransform.position;
        }

        if(other.gameObject.name == "fallJudge")
        {
            myTransform.position = pos;
        }
    }
}
