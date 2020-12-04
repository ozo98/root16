using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDirector : MonoBehaviour
{
    public GameManager gameManager;
    //여기서 게임오브젝트 접근해가지구 숫자 조절해도 될듯.. 카운트나 id같은겅ㅇㅇ
    //씬이 바뀔때는 상관없는데, 챕터 바뀔때마다는 꼭 한번씩 id, qeustCount초기화해줘야함. 메인화면에서 들어가는 경우도 있기 때문에.

    public void GoToTitle()
    {
        SoundManager2.instance.PlaySound("IntroBGM", 0);
        SceneManager.LoadScene("Main");
    }

    public void GoToMainMenu()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("MainMenu");
        SoundManager2.instance.StopSound("IntroBGM",0);
        SoundManager2.instance.PlaySound("SelectChapterBGM", 0);
    }
    public void ChangeChapterOne()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap1.Scene_1");
        SoundManager2.instance.StopSound("SelectChapterBGM", 0);
        SoundManager2.instance.PlaySound("Chapter1BGM", 0);
    }
    public void ChapOneFirstMiniGame()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap1.Scene_2");
    }
    public void ChangeChapterOneScene3()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap1.Scene_3");
    }
    public void ChapOneSecondMiniGame()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap1.Scene_4");
    }
    public void ChapTwoSceneOne()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap2.Scene_1");
        DataController.Instance.gameData.chapter1Clear = true;
        DataController.Instance.SaveGameData();
    }
    public void ChapTwoSceneTwo()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        if (DataController.Instance.gameData.chapter1Clear == true)
        {
            SceneManager.LoadScene("chap2.Scene_2");
            SoundManager2.instance.StopSound("Chapter1BGM", 0);
            SoundManager2.instance.PlaySound("Chapter2BGM", 0);
        }

        else
        {
            gameManager.chapterPanel.SetActive(true);
            gameManager.chapterText.text = "챕터1을 먼저 클리어해야 합니다.";
            Invoke("setActiveFalse", 2);
        }
    }
    public void ChapTwoFirstMiniGame() // 케이크 나눠주기
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap2.Scene_3");
    }
    public void Chap2Scene4()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap2.Scene_4");
    }

    public void Chap2MiniGame2() // 도형찾기(수수께끼)
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap2.Scene_5");
    }

    public void Chap2Scene6()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap2.Scene_6");
    }

    public void Chap2MiniGame3() // 쿠키나눠주기
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap2.Scene_7");
    }

    public void Chap2Scene8()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap2.Scene_8");
    }

    public void Chap2MiniGame4() // 찻잔 계산
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap2.Scene_9");
    }
    public void Chap2Scene10()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap2.Scene_10");
    }

    public void Chap2MiniGame5() // 시계 보기(디지털 시계)
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap2.Scene_11");
    }
    public void Chap2Scene12()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap2.Scene_12");
    }

    public void Chap3Scene1()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap3.Scene_1");
        DataController.Instance.gameData.chapter2Clear = true;
        DataController.Instance.SaveGameData();
    }

    public void ChapThreeSceneTwo()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        if (DataController.Instance.gameData.chapter2Clear == true)
        {
            SceneManager.LoadScene("chap3.Scene_2");
            SoundManager2.instance.StopSound("Chapter2BGM", 0);
            SoundManager2.instance.PlaySound("Chapter3BGM", 0);
        }
        else if (DataController.Instance.gameData.chapter2Clear == false)
        {
            gameManager.chapterPanel.SetActive(true);
            gameManager.chapterText.text = "챕터2를 먼저 클리어해야 합니다.";
            Invoke("setActiveFalse", 2);
        }
    }

    public void Chap3Scene2()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap3.Scene_2");
    }

    public void Chap3MiniGame1() // 규칙 찾아 꾸미기
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap3.Scene_3");
    }
    public void Chap3Scene4()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap3.Scene_4");
    }
    public void Chap3MiniGame2() // 빼기??인가
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap3.Scene_5");
    }
    public void Chap3Scene6()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap3.Scene_6");
    }
    public void Chap3MiniGame3() // 빼기 아니면 더하기
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap3.Scene_7");
    }
    public void Chap3Scene8()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap3.Scene_8");
    }
    public void Chap3MiniGame4() //홀짝홀짝
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap3.Scene_9");
    }
    public void Chap3Scene10()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        SceneManager.LoadScene("chap3.Scene_10");
    }
    public void Ending()
    {
        SendMessage("Fade");
        SceneManager.LoadScene("Ending");
        SoundManager2.instance.StopSound("Chapter3BGM", 0);
        SoundManager2.instance.PlaySound("IntroBGM", 0);
        DataController.Instance.gameData.chapter3Clear = true;
        DataController.Instance.SaveGameData();
    }
    public void EndingCredit()
    {
        SendMessage("Fade");
        SceneManager.LoadScene("EndingCredit");
    }
    void setActiveFalse()
    {
        SoundManager2.instance.PlaySound("Button0", 1);
        gameManager.chapterPanel.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
