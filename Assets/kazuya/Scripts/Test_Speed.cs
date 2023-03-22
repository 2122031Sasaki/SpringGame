//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Test_Speed : MonoBehaviour
//{
//    public float speed;
//    private float Turn;
//    // Start is called before the first frame update
//    void Start()
//    {
//        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody‚ðŽæ“¾
//        speed = 10.0f;
//        Turn = 1.0f;
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//    void FixedUpdate()
//    {
//        if (Input.GetKey(KeyCode.W))
//        {
//            GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
//        }
//        if (Input.GetKey(KeyCode.S))
//        {
//            GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * -speed * Time.deltaTime);
//        }
//        if (Input.GetKey(KeyCode.D))
//        {
//            GetComponent<Rigidbody>().MovePosition(transform.position + transform.right * speed * Time.deltaTime);
//            transform.Rotate(0, Turn, 0);
//        }
//        if (Input.GetKey(KeyCode.A))
//        {
//            GetComponent<Rigidbody>().MovePosition(transform.position + transform.right * -speed * Time.deltaTime);
//            transform.Rotate(0, -Turn, 0);
//        }
//    }
//}
