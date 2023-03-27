using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーの座標を取得
        //Vector3 PlayerPos = GameObject.Find("player_game").transform.position;
        
    }

    //ゴールに到達
    void OnTriggerEnter(Collider other)
    {
        //if(PlayerPos.x ==  &&  PlayerPos.y ==  && PlayerPos.z == )
        //{     細い道のほうにゴールした場合
        SceneManager.LoadScene("ResultScene");
        //}
       }
}
