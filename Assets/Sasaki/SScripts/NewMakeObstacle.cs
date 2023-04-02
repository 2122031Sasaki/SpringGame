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
        //1つ目の直線、その先のカーブ
        //大きさ変更
        kori.transform.localScale = new Vector3(16.0f, 16.0f, 16.0f);
        float rn = Random.Range(1450.0f, 1455.0f);
        //オブジェクト名、場所、向き(角度)
        Instantiate(kori, new Vector3(963.0f, 525.0f, rn), Quaternion.Euler(-90, 0, 0));

        rn = Random.Range(1451.0f, 1454.5f);
        Instantiate(kamakura, new Vector3(950.0f, 526.0f, rn), Quaternion.Euler(-90, 0, -90));

        star.transform.localScale = new Vector3(80.0f, 80.0f, 80.0f);
        rn = Random.Range(1452.0f, 1454.0f);
        Instantiate(star, new Vector3(1030.0f, 505.0f, rn), Quaternion.Euler(0, 90, 0));

        Instantiate(kori, new Vector3(1045.0f, 504.0f, 1452.0f), Quaternion.Euler(-90, 0, 0));

        daruma.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        rn = Random.Range(1449.0f, 1454.0f);
        Instantiate(daruma, new Vector3(1061.0f, 504.0f, rn), Quaternion.Euler(0, -90, 0));

        //2つ目の直線、その先のカーブ
        rn = Random.Range(1401.0f, 1406.0f);
        Instantiate(kori, new Vector3(1051.0f, 504.0f, rn), Quaternion.Euler(-90, 0, 0));

        rn = Random.Range(1401.0f, 1405.0f);
        Instantiate(kori, new Vector3(1039.0f, 504.0f, rn), Quaternion.Euler(-90, 0, 0));

        rn = Random.Range(1401.0f, 1405.0f);
        Instantiate(daruma, new Vector3(1017.0f, 504.0f, rn), Quaternion.Euler(0, 90, 0));

        rn = Random.Range(1401.2f, 1404.8f);
        Instantiate(kamakura, new Vector3(948.0f, 484.1f, rn), Quaternion.Euler(-90, 0, 90));

        rn = Random.Range(1400.0f, 1405.0f);
        Instantiate(daruma, new Vector3(918.0f, 483.0f, rn), Quaternion.Euler(0, 90, 0));

        //3つ目の直線、落とし穴前1
        rn = Random.Range(1357.0f, 1352.0f);
        Instantiate(kori, new Vector3(920.0f, 483.0f, rn), Quaternion.Euler(-90, 0, 0));

        Instantiate(star, new Vector3(934.5f, 483.8f, 1352.7f), Quaternion.Euler(0, 90, 0));

        rn = Random.Range(1351.0f, 1354.5f);
        Instantiate(kori, new Vector3(940.0f, 483.0f, rn), Quaternion.Euler(-90, 0, 0));

        rn = Random.Range(1351.0f, 1354.5f);
        Instantiate(kamakura, new Vector3(952.0f, 484.1f, rn), Quaternion.Euler(-90, 0, -90));

        rn = Random.Range(1351.0f, 1354.5f);
        Instantiate(daruma, new Vector3(963.0f, 483.0f, rn), Quaternion.Euler(0, -90, 0));

        rn = Random.Range(1351.0f, 1354.5f);
        Instantiate(daruma, new Vector3(970.0f, 483.0f, rn), Quaternion.Euler(0, -90, 0));

        rn = Random.Range(1342.0f, 1354.0f);
        Instantiate(kamakura, new Vector3(996.0f, 484.1f, rn), Quaternion.Euler(-90, 20, -90));

        Instantiate(daruma, new Vector3(1009.0f, 483.0f, 1325.0f), Quaternion.Euler(0, 0, 0));

        Instantiate(daruma, new Vector3(1011.0f, 483.0f, 1325.0f), Quaternion.Euler(0, 0, 0));

        Instantiate(kori, new Vector3(1025.0f, 483.0f, 1325.0f), Quaternion.Euler(-90, -90, 0));

        Instantiate(kamakura, new Vector3(1010.0f, 484.1f, 1293.0f), Quaternion.Euler(-90, 90, -90));

        Instantiate(kamakura, new Vector3(1020.0f, 484.1f, 1293.0f), Quaternion.Euler(-90, 90, -90));

        Instantiate(kamakura, new Vector3(1029.0f, 484.1f, 1293.0f), Quaternion.Euler(-90, 90, -90));

        //落とし穴後の直線1
        rn = Random.Range(1006.0f, 1018.0f);
        Instantiate(kori, new Vector3(rn, 241.9f, 846.0f), Quaternion.Euler(-90, 90, 0));

        Instantiate(kori, new Vector3(1020.0f, 241.9f, 846.0f), Quaternion.Euler(-90, -90, 0));

        rn = Random.Range(1022.0f, 1033.0f);
        Instantiate(kori, new Vector3(rn, 241.9f, 846.0f), Quaternion.Euler(-90, 90, 0));

        Instantiate(star, new Vector3(1040.0f, 242.8f, 840.0f), Quaternion.Euler(0, 45, 0));

        rn = Random.Range(1006.0f, 1032.0f);
        Instantiate(daruma, new Vector3(rn, 241.9f, 805.0f), Quaternion.Euler(0, 0, 0));

        rn = Random.Range(1006.0f, 1018.0f);
        Instantiate(daruma, new Vector3(rn, 241.9f, 790.0f), Quaternion.Euler(0, 0, 0));

        rn = Random.Range(1021.0f, 1027.0f);
        Instantiate(kamakura, new Vector3(rn, 242.9f, 790.0f), Quaternion.Euler(-90, 90, -90));

        rn = Random.Range(1006.0f, 1018.0f);
        Instantiate(daruma, new Vector3(rn, 241.9f, 777.0f), Quaternion.Euler(0, 0, 0));

        rn = Random.Range(1019.0f, 1023.0f);
        Instantiate(daruma, new Vector3(rn, 241.9f, 777.0f), Quaternion.Euler(0, 0, 0));

        rn = Random.Range(1024.0f, 1032.0f);
        Instantiate(daruma, new Vector3(rn, 241.9f, 777.0f), Quaternion.Euler(0, 0, 0));

        rn = Random.Range(1007.0f, 1017.0f);
        Instantiate(kamakura, new Vector3(rn, 242.9f, 769.0f), Quaternion.Euler(-90, 90, -90));

        rn = Random.Range(1019.0f, 1031.0f);
        Instantiate(kamakura, new Vector3(rn, 242.9f, 769.0f), Quaternion.Euler(-90, 90, -90));

        rn = Random.Range(1005.0f, 1012.0f);
        Instantiate(kori, new Vector3(rn, 241.7f, 752.0f), Quaternion.Euler(-90, 90, 0));

        rn = Random.Range(1013.0f, 1020.0f);
        Instantiate(daruma, new Vector3(rn, 241.7f, 752.0f), Quaternion.Euler(0, 0, 0));

        rn = Random.Range(1020.5f, 1027.5f);
        Instantiate(kamakura, new Vector3(rn, 242.8f, 752.0f), Quaternion.Euler(-90, 90, -90));

        rn = Random.Range(1028.0f, 1035.0f);
        Instantiate(daruma, new Vector3(rn, 241.7f, 752.0f), Quaternion.Euler(0, 0, 0));

        //落とし穴前2
        rn = Random.Range(720.0f, 725.0f);
        Instantiate(kamakura, new Vector3(1060.0f, 242.9f, rn), Quaternion.Euler(-90, 0, -90));

        rn = Random.Range(719.0f, 724.0f);
        Instantiate(kori, new Vector3(1073.0f, 241.8f, rn), Quaternion.Euler(-90, 0, 0));

        rn = Random.Range(719.0f, 724.0f);
        Instantiate(kori, new Vector3(1083.0f, 241.8f, rn), Quaternion.Euler(-90, 180, 0));

        rn = Random.Range(719.0f, 723.0f);
        Instantiate(kamakura, new Vector3(1093.0f, 242.9f, rn), Quaternion.Euler(-90, 0, -90));

        Instantiate(kamakura, new Vector3(1143.0f, 242.9f, 696.0f), Quaternion.Euler(-90, 0, -90));

        Instantiate(kamakura, new Vector3(1143.0f, 242.9f, 691.5f), Quaternion.Euler(-90, 0, -90));

        Instantiate(kamakura, new Vector3(1143.0f, 242.9f, 687.0f), Quaternion.Euler(-90, 0, -90));

        rn = Random.Range(1122.0f, 1127.0f);
        Instantiate(daruma, new Vector3(rn, 241.5f, 653.0f), Quaternion.Euler(0, 0, 0));

        rn = Random.Range(1128.0f, 1133.0f);
        Instantiate(daruma, new Vector3(rn, 241.5f, 653.0f), Quaternion.Euler(0, 0, 0));

        rn = Random.Range(1136.0f, 1141.0f);
        Instantiate(daruma, new Vector3(rn, 241.5f, 653.0f), Quaternion.Euler(0, 0, 0));

        rn = Random.Range(1142.0f, 1147.0f);
        Instantiate(daruma, new Vector3(rn, 241.5f, 653.0f), Quaternion.Euler(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
