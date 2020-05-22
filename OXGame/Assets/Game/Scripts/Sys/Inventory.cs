using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Inventory : MonoBehaviour
{

    [Header("내 용사들과 재화를 당담하는 스크립트")]

    [Tooltip("골드 재화")]
    public int gold = 0;
    [Tooltip("보석 재화")]
    public int jewel = 500;
    [Tooltip("나의 보유 용사")]
    public List<GameObject> my_hero_list = new List<GameObject>();

    [Space(25)]
    [Header("재화 보유량을 표기해줄 텍스트")]
    [Tooltip("GoldAmountTxt 라고 적혀 있는 것을 넣어주세요")]
    public Text my_gold_textbox;
    [Tooltip("JewelAmountTxt 라고 적혀 있는 것을 넣어주세요")]
    public Text my_jewel_textbox;


    private void Start()
    {
        RefreshUI();
    }

    #region "재화의 보유량 변동 관련"

    public void AddGold(int amount)
    {
        gold += amount;
        RefreshUI();
    }

    public void RemoveGold(int amount)
    {
        gold -= amount;
        RefreshUI();
    }

    public void AddJewel(int amount)
    {
        jewel += amount;
        RefreshUI();
    }

    public void RemoveJewel(int amount)
    {
        if(jewel - amount <0)
        {
            Debug.LogError("0보다 작아짐");
        }
        jewel -= amount;
        RefreshUI();
    }

    #endregion


    public void RefreshUI() //재화가 바뀔때마다 호출 되도록 할것
    {
        my_gold_textbox.text = gold.ToString();
        my_jewel_textbox.text = jewel.ToString();
    }

    public void AddHero(GameObject hero)
    {
        for (int i = 0; i < my_hero_list.Count; i++)
        {
            if (my_hero_list[i].GetComponent<CharacterInfo>().character_name == hero.GetComponent<CharacterInfo>().character_name)
            {
                my_hero_list[i].GetComponent<CharacterInfo>().curr_combined_amount++;
                return;
            }
        }
            GameObject add_hero = new GameObject();
            add_hero.AddComponent<CharacterInfo>();
            add_hero.GetComponent<CharacterInfo>().character_name = hero.GetComponent<CharacterInfo>().character_name;
            add_hero.GetComponent<CharacterInfo>().rank = hero.GetComponent<CharacterInfo>().rank;
            add_hero.GetComponent<CharacterInfo>().model = hero.GetComponent<CharacterInfo>().model;
            add_hero.GetComponent<CharacterInfo>().illust = hero.GetComponent<CharacterInfo>().illust;
            add_hero.GetComponent<CharacterInfo>().describe = hero.GetComponent<CharacterInfo>().describe;
            add_hero.GetComponent<CharacterInfo>().level = hero.GetComponent<CharacterInfo>().level;
            add_hero.GetComponent<CharacterInfo>().max_level = hero.GetComponent<CharacterInfo>().max_level;
            add_hero.GetComponent<CharacterInfo>().need_to_combine_amount = hero.GetComponent<CharacterInfo>().need_to_combine_amount;
            add_hero.GetComponent<CharacterInfo>().curr_combined_amount = hero.GetComponent<CharacterInfo>().curr_combined_amount;
            add_hero.GetComponent<CharacterInfo>().curr_need_combine_amount = hero.GetComponent<CharacterInfo>().curr_need_combine_amount;
            add_hero.GetComponent<CharacterInfo>().atk_increase_value = hero.GetComponent<CharacterInfo>().atk_increase_value;
            add_hero.GetComponent<CharacterInfo>().curr_atk = hero.GetComponent<CharacterInfo>().curr_atk;
            add_hero.GetComponent<CharacterInfo>().init_atk = hero.GetComponent<CharacterInfo>().init_atk;


            my_hero_list.Add(add_hero);
    }
}