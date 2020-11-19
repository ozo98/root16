using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeEffect : MonoBehaviour
{
    string targetMsg;
    public int charPerSeconds;
    Text msgText;
    int index;
    float interval;

    // 대화 더빙 관련
    public AudioClip[] talkSound; //각각의 사운드 파일
    AudioSource audioSource; //이걸 통해 플레이

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        msgText = GetComponent<Text>();
    }

    public void SetMsg(string msg)
    {
        targetMsg = msg;
        EffectStart();
    }

    void EffectStart()
    {
        msgText.text = "";
        index = 0;

        interval = 1.0f / charPerSeconds;
        Invoke("Effecting", interval);
    }

    void Effecting()
    {
        if(msgText.text == targetMsg)
        {
            EffectEnd();
            return;
        }

        msgText.text += targetMsg[index];
        index++;

        Invoke("Effecting", interval);
    }

    void EffectEnd()
    {

    }
}
