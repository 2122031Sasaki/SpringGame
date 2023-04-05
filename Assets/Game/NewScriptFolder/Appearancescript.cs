using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appearancescript : MonoBehaviour
{
    int selectCharaNumber;
    public GameObject Player_speed;
    public GameObject Player_turn;
    public GameObject Camera;
    public GameObject respawn;
    void Start()
    {
        selectCharaNumber= PlayerPrefs.GetInt("CHARA_NUMBER", 0);
        var obj3 = Instantiate(Camera, new Vector3(1019.75f, 548.25f, 1502.0f), Quaternion.Euler(20, 270.0f, 0));
        var obj4 = Instantiate(respawn, new Vector3(1022.0f, 546.0f, 1502.0f), Quaternion.Euler(0, 90.0f, 0));
        if (selectCharaNumber == 0)
        {
            var obj = Instantiate(Player_speed, new Vector3(1017.0f, 546f, 1502.0f), Quaternion.Euler(0, 90.0f, 0));
            obj3.gameObject.transform.parent = obj.gameObject.transform;
            obj4.gameObject.transform.parent = obj.gameObject.transform;
        }
        if(selectCharaNumber == 1)
        {
            var obj2 = Instantiate(Player_turn, new Vector3(1017.0f, 546f, 1502.0f), Quaternion.Euler(0, 90.0f, 0));
            obj3.gameObject.transform.parent = obj2.gameObject.transform;
            obj4.gameObject.transform.parent = obj2.gameObject.transform;
        }
    }

    void Update()
    {
        
    }
}
