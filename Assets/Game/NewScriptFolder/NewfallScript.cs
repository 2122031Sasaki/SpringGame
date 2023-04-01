using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityStandardAssets.Utility;

public class NewfallScript : MonoBehaviour
{
    private GameObject respawnObj;
    Rigidbody rb;
    bool fall;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        fall = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fall == true)
        {
            // プレイヤーの運動を停止
            this.rb.isKinematic = true;

            // 子オブジェクトを取得
            respawnObj = transform.GetChild(4).gameObject;

            // 子オブジェクトのワールド座標を取得
            Vector3 respawnPos = respawnObj.transform.position;

            // リスポーン地点を設定・プレイヤーを移動
            respawnPos.y += 5.0f;

            Vector3 worldAngle = respawnObj.transform.eulerAngles;
            worldAngle.x = 0.0f;
            worldAngle.y = 0.0f; 
            worldAngle.z = 0.0f;

            this.gameObject.transform.position = respawnPos;
            this.gameObject.transform.eulerAngles = worldAngle;

            // プレイヤーの運動を再始動
            this.rb.isKinematic = false;

            fall= false;
        }
    }

    // 落下判定＆リスポーン
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FallDetector")
        {
            fall= true;
        }
    }
}
