using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class IntroScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public SceneDirector sceneDirector;

    public void Start()
    {
        Invoke("LoadNextScene", 21);
    }

    void Update()
    {

    }

    public void LoadNextScene()
    {
        //다음 씬을 불러온다.
        sceneDirector.GoToTitle();
    }
}
