using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMakeObstacle : MonoBehaviour
{
    public GameObject kori;
    public GameObject kamakura;
    public GameObject daruma;
    public GameObject star;

    // Start is called before the first frame update
    void Start()
    {
        //kori.transform.localScale = new Vector3(50.0f, 50.0f, 50.0f);
        float rn = Random.Range(1450.0f, 1454.0f);
        Instantiate(kori, new Vector3(970.0f, 525.0f, rn), Quaternion.identity);

        //kamakura.transform.localScale = new Vector3(50.0f, 50.0f, 50.0f);
        rn = Random.Range(1450.0f, 1454.0f);
        Instantiate(kamakura, new Vector3(950.0f, 526.0f, rn), Quaternion.identity);

        //daruma.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        rn = Random.Range(1450.0f, 1454.0f);
        Instantiate(daruma, new Vector3(1061.0f, 505.0f, rn), Quaternion.identity);

        rn = Random.Range(1450.0f, 1454.0f);
        Instantiate(star, new Vector3(1030.0f, 505.0f, rn), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
