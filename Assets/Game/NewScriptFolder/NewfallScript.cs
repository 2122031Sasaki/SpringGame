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
            // �v���C���[�̉^�����~
            this.rb.isKinematic = true;

            // �q�I�u�W�F�N�g���擾
            respawnObj = transform.GetChild(4).gameObject;

            // �q�I�u�W�F�N�g�̃��[���h���W���擾
            Vector3 respawnPos = respawnObj.transform.position;

            // ���X�|�[���n�_��ݒ�E�v���C���[���ړ�
            respawnPos.y += 5.0f;

            Vector3 worldAngle = respawnObj.transform.eulerAngles;
            worldAngle.x = 0.0f;
            worldAngle.y = 0.0f; 
            worldAngle.z = 0.0f;

            this.gameObject.transform.position = respawnPos;
            this.gameObject.transform.eulerAngles = worldAngle;

            // �v���C���[�̉^�����Ďn��
            this.rb.isKinematic = false;

            fall= false;
        }
    }

    // �������聕���X�|�[��
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FallDetector")
        {
            fall= true;
        }
    }
}
