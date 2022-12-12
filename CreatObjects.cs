using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatObjects : MonoBehaviour
{
    // Prefab
    public GameObject prefabMouse;
    List<GameObject> objs;

    void Start()
    {
        objs = new List<GameObject>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
           
            for(int i = 0;i<20;i++)
            {
                GameObject s1 = Instantiate(prefabMouse);
                //s1.transform.position = new Vector3(1, 0, 0);
                s1.transform.position = Random.insideUnitSphere * 3;
                //s1.transform.position = Random.onUnitSphere * 3;
                objs.Add(s1);
            }
        }
        if(Input.GetButtonDown("Fire2"))
        {
            foreach(var s1 in objs)
            {
                if(!s1.GetComponent<Rigidbody>())    // judge whether has the component already
                { s1.AddComponent<Rigidbody>(); }
            }
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log($"List³¤¶È£º{objs.Count}");
            foreach (var s1 in objs)
            { Destroy(s1); }
            objs.Clear();
        }

    }
}
