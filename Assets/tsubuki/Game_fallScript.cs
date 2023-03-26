using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_fallScript : MonoBehaviour
{
    private GameObject respawnObj;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 落下判定＆リスポーン
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FallDetector")
        {
            // プレイヤーの運動を停止
            this.rb.isKinematic = true;

            // 子オブジェクトを取得
            respawnObj = other.gameObject.transform.GetChild(0).gameObject;

            // 子オブジェクトのワールド座標を取得
            Vector3 respawnPos = respawnObj.transform.position;
            
            // リスポーン地点を設定・プレイヤーを移動
            respawnPos.y += 5.0f;
            this.gameObject.transform.position = respawnPos;

            // プレイヤーの運動を再始動
            this.rb.isKinematic = false;
        }
    }
}
