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
        float rn = Random.Range(-4.0f, 5.0f);
        Instantiate(kori, new Vector3(rn, 2.0f, 4.0f), Quaternion.identity);

        rn = Random.Range(-4.0f, 5.0f);
        Instantiate(kamakura, new Vector3(rn, 2.0f, 14.0f), Quaternion.identity);

        rn = Random.Range(-4.0f, 5.0f);
        Instantiate(daruma, new Vector3(rn, 2.0f, 24.0f), Quaternion.identity);

        rn = Random.Range(-4.0f, 5.0f);
        Instantiate(star, new Vector3(rn, 2.0f, 8.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
