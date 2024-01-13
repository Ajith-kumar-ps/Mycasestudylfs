using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    private VideoPlayer myVideo;
    // Start is called before the first frame update
    void Start()
    {
        myVideo = GetComponent<VideoPlayer>();
        myVideo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (myVideo.enabled)
        {
            myVideo.enabled = false;
        }
        else
        {
            myVideo.enabled = true;
        }
    }
}
