using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObj : MonoBehaviour
{
    public GameObject manager;
    public GameObject destroyObj;
    public bool itemTouched;
    public bool muteki;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager");
        itemTouched = false;
        muteki = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Game_Newstar(Clone)")
        {
            StartCoroutine("Muteki");
            destroyObj = other.gameObject;
            itemTouched = true;
            Destroy(destroyObj);
        }

        if (other.gameObject.name == "Game_koori(Clone)")
        {
            destroyObj = other.gameObject;
            if (muteki == false)
            {
                manager.GetComponent<timeScript>().Addtime();
            }
            Destroy(destroyObj);
        }

        if (other.gameObject.name == "Game_kamakura(Clone)")
        {
            destroyObj = other.gameObject;
            if (muteki == false)
            {
                manager.GetComponent<timeScript>().Addtime();
            }
            Destroy(destroyObj);
        }

        if (other.gameObject.name == "Game_yukikaku(Clone)")
        {
            destroyObj = other.gameObject;
            if (muteki == false)
            {
                manager.GetComponent<timeScript>().Addtime();
            }
            Destroy(destroyObj);
        }
    }

    IEnumerator Muteki()
    {
        muteki = true;
        yield return new WaitForSeconds(10.0f);
        muteki = false;
    }

}
