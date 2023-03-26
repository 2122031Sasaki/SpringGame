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

    // �������聕���X�|�[��
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FallDetector")
        {
            // �v���C���[�̉^�����~
            this.rb.isKinematic = true;

            // �q�I�u�W�F�N�g���擾
            respawnObj = other.gameObject.transform.GetChild(0).gameObject;

            // �q�I�u�W�F�N�g�̃��[���h���W���擾
            Vector3 respawnPos = respawnObj.transform.position;
            
            // ���X�|�[���n�_��ݒ�E�v���C���[���ړ�
            respawnPos.y += 5.0f;
            this.gameObject.transform.position = respawnPos;

            // �v���C���[�̉^�����Ďn��
            this.rb.isKinematic = false;
        }
    }
}
