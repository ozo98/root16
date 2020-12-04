using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class IntroScript : MonoBehaviour
{
    public SceneDirector sceneDirector;
    public int time;

    public void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        int curScene = scene.buildIndex;
        if(curScene == 0) //인트로 씬이라면
        {
            Invoke("LoadTitle", time);
        }
        if (curScene == 29) //엔딩 씬이라면
        {
            Invoke("LoadCredit", time);
        }
    }

    void Update()
    {

    }

    public void LoadTitle()
    {
        sceneDirector.GoToTitle();
    }
    public void LoadCredit()
    {
        sceneDirector.EndingCredit();
    }
}
