using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    public Image panel;
    float time = 0f;
    float fTime = 3f;

    public void Start()
    {
        Fade();
    }

    public void Fade()
    {
        StartCoroutine(FadeFlow());

    }
    IEnumerator FadeFlow()
    {
        panel.gameObject.SetActive(true);
        time = 0f;
        Color alpha = panel.color;
        while (alpha.a > 0f)
        {
            time += Time.deltaTime / fTime;
            alpha.a = Mathf.SmoothStep(1, 0, time);
            panel.color = alpha;
            yield return null;
        }
        time = 0f;

        yield return new WaitForSeconds(1f);

        while (alpha.a < 1f)
        {
            time += Time.deltaTime / fTime;
            alpha.a = Mathf.SmoothStep(0, 1, time);
            panel.color = alpha;
            yield return null;
        }
        //panel.gameObject.SetActive(false);
        LoadNextScene();
        yield return null;
    }

    public void LoadNextScene()
    {
        //현재 씬 정보
        Scene scene = SceneManager.GetActiveScene();
        //현재 씬의 빌드 순서
        int curScene = scene.buildIndex;
        //현재 씬 바로 다음 씬을 가져오기 위해 +1
        int nextScene = curScene + 1;
        //다음 씬을 불러온다.
        SceneManager.LoadScene(nextScene);
    }
}
