using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManger : MonoBehaviour
{
    private AudioSource BGMPlayer;
    public AudioClip BGM;

    void Start()
    {
        BGMPlayer = GetComponent<AudioSource>();  //myAudio에 컴퍼넌트에있는 AudioSource넣기
        DontDestroyOnLoad(BGMPlayer);
        BGMPlayer.Play();
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "chap2.Scene_1")
        {
            Destroy(BGMPlayer);
        }

        if (SceneManager.GetActiveScene().name == "chap3.Scene_1")
        {
            Destroy(BGMPlayer);
        }

        if (SceneManager.GetActiveScene().name == "Ending")
        {
            Destroy(BGMPlayer);
        }
    }
}
