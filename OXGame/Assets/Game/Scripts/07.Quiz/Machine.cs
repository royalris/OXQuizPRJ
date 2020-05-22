using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Machine : MonoBehaviour
{
    public float delay_time;

    public Text category_txt;
    public QuestionsLoader loader;


    void SetCategory()
    {
        int max_count = loader.Category.Length;
        int rand = Random.Range(0, max_count);

        SendInGameInfo.quests = loader.SetQuiz(loader.Category[rand]);

        // 슬롯 애니메이션 작동
        StartCoroutine("GameStart");
        category_txt.text = loader.Category[rand];
        print("asdas");
    }


    IEnumerator GameStart()
    {
        yield return new WaitForSeconds(delay_time);
        this.gameObject.SetActive(false);
    }
}
