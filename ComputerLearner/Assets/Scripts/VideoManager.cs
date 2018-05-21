using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour {

    public VideoPlayer vid;
    public GameObject Redical;
    public GameObject cameraUI;
    public GameObject MoboUI;
    public GameObject VideoPlayer;
    public Renderer rend;
    public Color ScreenColorDone = Color.black;
    public Color ScreenColorBegin = Color.white;
    public GameObject ScreenCanvas;
    public Animator Screen;
    public bool VideoOver = false;
    public bool cont = false;


    void Start()
    {
        cameraUI.SetActive(false);
        MoboUI.SetActive(false);
        Redical.SetActive(false);
        ScreenCanvas.SetActive(false);

        vid.loopPointReached += CheckOver;
    }

    private void Update()
    {
        if(VideoOver == true)
        {
            VideoPlayer.SetActive(false);
            ScreenCanvas.SetActive(true);
            rend.material.color = ScreenColorDone;

            if(cont == true)
            {
                ScreenCanvas.SetActive(false);
            }
        }
    }

    public void Replay()
    {
        rend.material.color = ScreenColorBegin;
        VideoPlayer.SetActive(true);
        ScreenCanvas.SetActive(false);
        Redical.SetActive(false);
        VideoOver = false;

    }

    public void Continue()
    {
        Screen.SetBool("exit", true);
        cameraUI.SetActive(true);
        MoboUI.SetActive(true);
        Redical.SetActive(true);
        cont = true;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        print("Video Is Over");
        //cameraUI.SetActive(true);
        //MoboUI.SetActive(true);
        Redical.SetActive(true);
        VideoOver = true;
    }
}
