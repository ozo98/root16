using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDirector : MonoBehaviour
{
    public GameManager gameManager;
    //여기서 게임오브젝트 접근해가지구 숫자 조절해도 될듯.. 카운트나 id같은겅ㅇㅇ
    //씬이 바뀔때는 상관없는데, 챕터 바뀔때마다는 꼭 한번씩 id, qeustCount초기화해줘야함. 메인화면에서 들어가는 경우도 있기 때문에.

    public void GoToMainMenu()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("MainMenu");
    }
    public void ChangeChapterOne()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap1.Scene_1");
    }
    public void ChapOneFirstMiniGame()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap1.Scene_2");
    }
    public void ChangeChapterOneScene3()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap1.Scene_3");
    }
    public void ChapOneSecondMiniGame()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap1.Scene_4");
    }
    public void ChapTwoSceneOne()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap2.Scene_1");
        DataController.Instance.gameData.chapter1Clear = true;
        DataController.Instance.SaveGameData();
    }
    public void ChapTwoSceneTwo()
    {
        SoundManager.instance.PlaySound();
        if (DataController.Instance.gameData.chapter1Clear == true)
            SceneManager.LoadScene("chap2.Scene_2");
        else
        {
            gameManager.chapterPanel.SetActive(true);
            gameManager.chapterText.text = "챕터1을 먼저 클리어해야 합니다.";
            Invoke("setActiveFalse", 2);
        }
    }
    public void ChapTwoFirstMiniGame()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap2.Scene_3");
    }
    public void Chap2Scene4()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap2.Scene_4");
    }
    public void Chap2MiniGame2()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap2.Scene_7");
    }
    public void Chap2Scene8()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap2.Scene_8");
    }
    public void Chap2MiniGame3()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap2.Scene_9");
    }
    public void Chap2Scene10()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap2.Scene_10");
    }
    public void Chap2MiniGame4()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap2.Scene_11");
    }
    public void Chap2Scene12()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap2.Scene_12");
    }
    public void Chap3Scene1()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap3.Scene_1");
    }
    public void ChapThreeSceneTwo()
    {
        SoundManager.instance.PlaySound();
        if (DataController.Instance.gameData.chapter2Clear == true)
            SceneManager.LoadScene("chap3.Scene_2");
        else if (DataController.Instance.gameData.chapter2Clear == false)
        {
            gameManager.chapterPanel.SetActive(true);
            gameManager.chapterText.text = "챕터2를 먼저 클리어해야 합니다.";
            Invoke("setActiveFalse", 2);
        }

    }

    public void Chap3Scene2()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap3.Scene_2");
    }

    public void Chap3MiniGame1()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap3.Scene_3");
    }
    public void Chap3Scene4()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap3.Scene_4");
    }
    public void Chap3MiniGame2()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap3.Scene_5");
    }
    public void Chap3Scene6()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap3.Scene_6");
    }
    public void Chap3MiniGame3()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap3.Scene_7");
    }
    public void Chap3Scene8()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap3.Scene_8");
    }
    public void Chap3MiniGame4()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap3.Scene_9");
    }
    public void Chap3Scene10()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("chap3.Scene_10");
    }
    public void Ending()
    {
        SoundManager.instance.PlaySound();
        SceneManager.LoadScene("Ending");
    }
    void setActiveFalse()
    {
        SoundManager.instance.PlaySound();
        gameManager.chapterPanel.SetActive(false);
    }
}
