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
        //�v���C���[�̍��W���擾
        //Vector3 PlayerPos = GameObject.Find("player_game").transform.position;
        
    }

    //�S�[���ɓ��B
    void OnTriggerEnter(Collider other)
    {
        //if(PlayerPos.x ==  &&  PlayerPos.y ==  && PlayerPos.z == )
        //{     �ׂ����̂ق��ɃS�[�������ꍇ
        SceneManager.LoadScene("ResultScene");
        //}
       }
}
