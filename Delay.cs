using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    // Prefab
    public GameObject prefabMouse;
    public float speed =3;
    List<GameObject> objs;


    void Start()
    {
        Debug.Log("Start" + Time.time);
        objs = new List<GameObject>();
       
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        { StartCoroutine(TestCoroutine(100)); }
    }
    void Create(int n)
    {
        for (int i = 0; i < n; i++)
        {
            GameObject s1 = Instantiate(prefabMouse);
            s1.transform.position = Random.insideUnitSphere * 3;
            objs.Add(s1);
        }
    }
    void DestroyAll()
    {
        Debug.Log($"List长度：{objs.Count}");
        foreach (var s1 in objs)
        { Destroy(s1); }
        objs.Clear();
    }
    IEnumerator TestCoroutine(int n)
    {
        Create(n);

        // WaitForSeconds 等待几秒
        // yield return new WaitForSeconds(2);
        // yield return null 代表等待一帧
        yield return null;
        
        for(int i = 0;i < 400;i++)
        {
            foreach(var obj in objs)
            {
                // Move
                Vector3 from = obj.transform.position;
                Vector3 to = transform.position;
                Vector3 dir = to - from;
                obj.transform.position += dir.normalized * speed * Time.deltaTime;

                // Scale change
                obj.transform.localScale += new Vector3(2f, 2f, 2f) * Time.deltaTime;
            }
            yield return null;
        }

        DestroyAll();
    }
    

  
   
}
