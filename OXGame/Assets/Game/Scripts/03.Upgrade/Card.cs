using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [HideInInspector]
    public GameObject hero;


    public Text combine_value_text;
    public Text max_combine_value_text;
    public Text atk_text;

    public GameObject upgrade_btn;
    bool upgrade_enable;

    private void OnEnable()
    {
        Refresh();
    }

    public void Refresh()
    {
        CharacterInfo charinfo = hero.GetComponent<CharacterInfo>();

        int combine_amont = charinfo.curr_combined_amount;
        int max_amount = charinfo.need_to_combine_amount[charinfo.level - 1];

        combine_value_text.text = combine_amont.ToString();
        max_combine_value_text.text = max_amount.ToString();
        BtnEnable();
        if (combine_amont - max_amount <= 0)
        {
            //upgrade_btn.GetComponent<Button>().enabled = false;
        }
    }
    void BtnEnable()
    {

    }

    public void Upgrade()
    {
        hero.GetComponent<CharacterInfo>().LevelUp();
        Refresh();
        print(hero.GetComponent<CharacterInfo>().need_to_combine_amount[hero.GetComponent<CharacterInfo>().level]);
        print(GameObject.Find("Inventory").GetComponent<Inventory>().my_hero_list[0].GetComponent<CharacterInfo>().need_to_combine_amount[GameObject.Find("Inventory").GetComponent<Inventory>().my_hero_list[0].GetComponent<CharacterInfo>().level]);
    }
   
}