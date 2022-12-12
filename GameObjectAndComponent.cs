using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 1.GameObject.Find(名字）【Unable to obtain the disabled object】
 * 2.Tag                   【Unable to obtain the disabled object】
 * 3.transform.Find
 */
public class GameObjectAndComponent : MonoBehaviour
{
    [SerializeField]
    private Transform cam;
    //public Transform cam;

    void Start()
    {
        //Rigidbody rb1 = this.gameObject.GetComponent<Rigidbody>();
        //Rigidbody rb2 = this.GetComponent<Rigidbody>();        // when the script runs,the ball must be mounted on the script.
        //MeshRenderer mr = GetComponent<MeshRenderer>();
        //MeshFilter mf = GetComponent<MeshFilter>();

        //Vector3 pos = transform.position;

        //Transform trans = GetComponent<Transform>();  // one object has only one "transform" component.
        //pos = trans.position;

        //Transform t = transform.gameObject.GetComponent<Rigidbody>().transform.transform.gameObject.transform;

        // through name
        GameObject cam = GameObject.Find("Main Camera");
        Debug.Log("主摄像机：" + cam);

        // through tag
        GameObject cam2 = GameObject.FindGameObjectWithTag("MainCamera");
        Debug.Log("主摄像机2：" + cam);

        GameObject[] all = GameObject.FindGameObjectsWithTag("Test");

    }

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            GameObject unitychan = GameObject.Find("unitychan_dynamic");
            Transform leg = unitychan.transform.Find("Character1_Reference/Character1_Hips/Character1_RightUpLeg/Character1_RightLeg");
            Debug.Log("leg:" + leg.name);

            // Name of the upper level
            Transform trans = unitychan.transform.Find("Character1_Reference/..");
            Debug.Log("trans:" + trans.name);

            cam.gameObject.SetActive(!cam.gameObject.activeInHierarchy);
        }
    }
}
