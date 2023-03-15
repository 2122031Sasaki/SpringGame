using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddtimeScript : MonoBehaviour
{
    public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "cube")
        {
            Destroy(collision.gameObject);
            manager.GetComponent<timeScript>().Addtime();
        }
        
    }

}
