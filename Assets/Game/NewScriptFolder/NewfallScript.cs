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
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        fall = false;
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (fall == true)
        {
            // �v���C���[�̉^�����~
            this.rb.isKinematic = true;

            time += Time.deltaTime;

            // �q�I�u�W�F�N�g���擾
            respawnObj = transform.GetChild(4).gameObject;

            // �q�I�u�W�F�N�g�̃��[���h���W���擾
            Vector3 respawnPos = respawnObj.transform.position;

            // ���X�|�[���n�_��ݒ�E�v���C���[���ړ�
            respawnPos.y += 8.0f;
            respawnPos.z += 8.0f;

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

        if (time < 2 && time!= 0.0f)
        {
            Transform myTransform = this.transform;
            Vector3 pos = myTransform.position;
            pos.z -= 0.05f;
            myTransform.position = pos;
            time = 0.0f;
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
