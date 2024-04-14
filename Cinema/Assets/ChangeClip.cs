using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeClip : MonoBehaviour
{    
    VideoPlayer videoPlayer;
    Image pausePlayButtonIcon;
    Button pausePlayButton, exitButton;
    public Button[] buttons;
    public VideoClip[] clips;
    public Sprite[] icons;
    public int sceneIndex=0;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GameObject.Find("VideoPlayer").GetComponent<VideoPlayer>();        
        pausePlayButtonIcon = GameObject.Find("PausePlayButton").GetComponent<Image>();
        pausePlayButton = GameObject.Find("PausePlayButton").GetComponent<Button>();
        pausePlayButton.onClick.AddListener(PausePlay);
        exitButton = GameObject.Find("ExitButton").GetComponent<Button>();
        exitButton.onClick.AddListener(()=>Exit(sceneIndex));
        for (int i = 0; i < buttons.Length; i++)
        {
            int temp = i;
            buttons[i].onClick.AddListener(()=>Play(temp));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(videoPlayer.isPlaying){
            // playButton.sprite = Resources.Load <Sprite>("Assets/Oculus/SampleFramework/Usage/SpatialAnchor/Textures/OCUI_24_Filled_2x.png");
            pausePlayButtonIcon.sprite = icons[1];
        }
        else{
            pausePlayButtonIcon.sprite = icons[0];
        }
        
        // if(Input.GetKeyDown(KeyCode.Alpha1)){
        //     videoPlayer.clip = clips[0];
        //     videoPlayer.Play();
        // }        
    }

    void PausePlay(){
        if(videoPlayer.isPlaying){
            videoPlayer.Pause();
        }
        else{
            videoPlayer.Play();
        }
    }

    void Play(int i){
        videoPlayer.clip = clips[i];
        videoPlayer.Play();
    }

    void Exit(int index){
        SceneManager.LoadScene(index);
    }
}
