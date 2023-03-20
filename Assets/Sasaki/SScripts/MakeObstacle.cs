using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float n = Random.Range(-4.0f, 5.0f);
        // Cylinder�v���n�u��GameObject�^�Ŏ擾
        GameObject obj = (GameObject)Resources.Load("Cylinder");
        // Cylinder�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(obj, new Vector3(n, 2.0f, 14.0f), Quaternion.identity);
        n = Random.Range(-4.0f, 5.0f);
        Instantiate(obj, new Vector3(n, 2.0f, 24.0f), Quaternion.identity);

        float m = Random.Range(-4.0f, 5.0f);
        // Cube�v���n�u��GameObject�^�Ŏ擾
        GameObject cuob = (GameObject)Resources.Load("Cube");
        // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(cuob, new Vector3(n, 2.0f, 4.0f), Quaternion.identity);
        m = Random.Range(-4.0f, 5.0f);
        Instantiate(cuob, new Vector3(n, 2.0f, 18.0f), Quaternion.identity);

        float k = Random.Range(-4.0f, 5.0f);
        // Cube�v���n�u��GameObject�^�Ŏ擾
        GameObject sphob = (GameObject)Resources.Load("Sphere");
        // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(sphob, new Vector3(n, 2.0f, 8.0f), Quaternion.identity);
        k = Random.Range(-4.0f, 5.0f);
        Instantiate(sphob, new Vector3(n, 2.0f, 28.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
