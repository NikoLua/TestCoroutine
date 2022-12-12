using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    AudioSource source;
    public List<AudioClip> clips;
    int index;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            source.clip = clips[index];
            source.Play();

            index++;
            if (index >= clips.Count) { index = 0; }
        }
       
    }
}
