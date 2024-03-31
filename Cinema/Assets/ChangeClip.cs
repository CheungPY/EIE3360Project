using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChangeClip : MonoBehaviour
{
    GameObject videoObject;
    VideoPlayer videoPlayer;
    public VideoClip[] clips;

    // Start is called before the first frame update
    void Start()
    {        
        videoObject = GameObject.Find("VideoPlayer");
        videoPlayer = videoObject.GetComponent<VideoPlayer>();        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P)){
            videoPlayer.clip = clips[1];
            videoPlayer.Play();
        }
        if(Input.GetKey(KeyCode.O)){
            videoPlayer.clip = clips[0];
            videoPlayer.Play();
        }
    }
}
