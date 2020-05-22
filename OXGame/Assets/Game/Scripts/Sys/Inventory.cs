using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Inventory : MonoBehaviour
{
    private int gold = 0;
    public int jewel = 500;
    public List<GameObject> my_hero_list = new List<GameObject>();

    public GameObject my_gold_UI;
    public GameObject my_jewel_UI;

    private Text my_gold_text;
    private Text my_jewel_text;

    private void Awake()
    {
        my_gold_text = my_gold_UI.transform.GetChild(1).GetComponent<Text>();
        my_jewel_text = my_jewel_UI.transform.GetChild(1).GetComponent<Text>();
    }

    private void Start()
    {
        RefreshUI();
    }

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

    public void RefreshUI()
    {
        my_gold_text.text = gold.ToString();
        my_jewel_text.text = jewel.ToString();
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