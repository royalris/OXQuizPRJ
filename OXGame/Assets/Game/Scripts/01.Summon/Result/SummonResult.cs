using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummonResult : MonoBehaviour
{
    private Sprite hero_illust;
    public Image hero_image;
    public Text hero_name_textbox;
    public Text hero_rank_textbox;
    private string hero_name;
    private string hero_rank;
    public void ShowResult(GameObject hero)
    {
        hero_illust = hero.GetComponent<CharacterInfo>().illust;
        hero_name = hero.GetComponent<CharacterInfo>().character_name;
        hero_rank = hero.GetComponent<CharacterInfo>().rank.ToString();
        hero_image.sprite = hero_illust;
    }

    public void Confirm()
    {
        gameObject.SetActive(false);
    }
}