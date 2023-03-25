using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObstacle : MonoBehaviour
{
    public GameObject kori;
    public GameObject kamakura;
    public GameObject daruma;
    public GameObject star;

    // Start is called before the first frame update
    void Start()
    {
        float rn = Random.Range(-4.0f, 5.0f);
        //    // CylinderプレハブをGameObject型で取得
        //    GameObject obj = (GameObject)Resources.Load("Cylinder");
        //    // Cylinderプレハブを元に、インスタンスを生成、
        //    Instantiate(obj, new Vector3(n, 2.0f, 14.0f), Quaternion.identity);
        //    n = Random.Range(-4.0f, 5.0f);
        //    Instantiate(obj, new Vector3(n, 2.0f, 24.0f), Quaternion.identity);

        //    float m = Random.Range(-4.0f, 5.0f);
        //    // CubeプレハブをGameObject型で取得
        //    GameObject cuob = (GameObject)Resources.Load("Cube");
        //    // Cubeプレハブを元に、インスタンスを生成、
        //    Instantiate(cuob, new Vector3(n, 2.0f, 4.0f), Quaternion.identity);
        //    m = Random.Range(-4.0f, 5.0f);
        //    Instantiate(cuob, new Vector3(n, 2.0f, 18.0f), Quaternion.identity);

        //    float k = Random.Range(-4.0f, 5.0f);
        //    // CubeプレハブをGameObject型で取得
        //    GameObject sphob = (GameObject)Resources.Load("Sphere");
        //    // Cubeプレハブを元に、インスタンスを生成、
        //    Instantiate(sphob, new Vector3(n, 2.0f, 8.0f), Quaternion.identity);
        //    k = Random.Range(-4.0f, 5.0f);
        //    Instantiate(sphob, new Vector3(n, 2.0f, 28.0f), Quaternion.identity);

        //kori.transform.localScale = new Vector3(50.0f, 50.0f, 50.0f);
        Instantiate(kori, new Vector3(rn, 2.0f, 4.0f), Quaternion.Euler(-90, 0, 0));

        rn = Random.Range(-4.0f, 5.0f);
        Instantiate(kamakura, new Vector3(rn, 2.0f, 14.0f), Quaternion.identity);

        rn = Random.Range(-4.0f, 5.0f);
        Instantiate(daruma, new Vector3(rn, 2.0f, 24.0f), Quaternion.identity);

        rn = Random.Range(-4.0f, 5.0f);
        Instantiate(star, new Vector3(rn, 2.0f, 8.0f), Quaternion.identity);

        Instantiate(kori, new Vector3(rn, 2.0f, 34.0f), Quaternion.Euler(-90, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
