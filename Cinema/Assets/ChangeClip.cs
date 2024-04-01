using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class ChangeClip : MonoBehaviour
{
    GameObject videoObject,playButtonObject;
    VideoPlayer videoPlayer;
    Image playButton;
    public VideoClip[] clips;
    public Sprite[] icons;

    // Start is called before the first frame update
    void Start()
    {        
        videoObject = GameObject.Find("VideoPlayer");
        videoPlayer = videoObject.GetComponent<VideoPlayer>();
        playButtonObject = GameObject.Find("PlayButton");
        playButton = playButtonObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(videoPlayer.isPlaying){
            // playButton.sprite = Resources.Load <Sprite>("Assets/Oculus/SampleFramework/Usage/SpatialAnchor/Textures/OCUI_24_Filled_2x.png");
            playButton.sprite = icons[1];
        }
        else{
            playButton.sprite = icons[0];
        }

        if(Input.GetKeyDown(KeyCode.Alpha1)){
            videoPlayer.clip = clips[0];
            videoPlayer.Play();
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            videoPlayer.clip = clips[1];
            videoPlayer.Play();
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            videoPlayer.clip = clips[2];
            videoPlayer.Play();
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)){
            videoPlayer.clip = clips[3];
            videoPlayer.Play();
        }
        if(Input.GetKeyDown(KeyCode.Alpha5)){
            videoPlayer.clip = clips[4];
            videoPlayer.Play();
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            if(videoPlayer.isPaused){
                videoPlayer.Play();
            }
            else{
                videoPlayer.Pause();
            }
        }
    }
}
