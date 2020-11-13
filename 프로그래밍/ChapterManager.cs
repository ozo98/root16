using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterManager : MonoBehaviour
{
    //챕터 선택 잠금
    public GameObject chapter2Locked;
    public GameObject chapter3Locked;

    //챕터 클리어 여부
    public GameObject chapter1Clear;
    public GameObject chapter2Clear;
    public GameObject chapter3Clear;
    
    void Start()
    {
        // 잠금 해제 
        if (DataController.Instance.gameData.chapter1Clear == true)
            chapter2Locked.SetActive(false);
        if (DataController.Instance.gameData.chapter2Clear == true)
            chapter3Locked.SetActive(false);

        // 클리어 여부 표시
        if (DataController.Instance.gameData.chapter1Clear == true)
            chapter1Clear.SetActive(true);
        if (DataController.Instance.gameData.chapter2Clear == true)
            chapter2Clear.SetActive(true);
        if (DataController.Instance.gameData.chapter3Clear == true)
            chapter1Clear.SetActive(true);
    }
}
