using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonProceedure
{
    Summon summon;
    GameObject inventory;
    Inventory inven;
    int gotcha_num;
    GameObject popup;

    enum Rare_rate {C,B,A,S , none};
    Rare_rate rare_rate;

    GameObject result_hero;

    public SummonProceedure(Summon _summon, GameObject _inventory , GameObject _popup)
    {
        summon = _summon;
        inventory = _inventory;
        inven = inventory.GetComponent<Inventory>();
        popup = _popup;
    }

    public void Summon()
    {
        if (CheckJewel())
        {
            ConsumJewel();
        }
        else
        {
            SendMessageNoJewel();
            return;
        }
    }

    bool CheckJewel()
    {
        bool hasJewel = false;

        if (inven.jewel >= 50)
        {
            hasJewel = true;
        }
        else
        {
            hasJewel = false;
        }

        return hasJewel;
    }
    void SendMessageNoJewel()
    {
        
    }

    void ConsumJewel()
    {
        inven.jewel -= 50;
        inven.RefreshUI();
        DiceRolling();
    }

    void DiceRolling()
    {
        gotcha_num = Random.Range(0, 100);

        if (gotcha_num < 9)
        {
            rare_rate = Rare_rate.S;
        }
        if (gotcha_num > 9 && gotcha_num < 33)
        {
            rare_rate = Rare_rate.A;
        }
        if (gotcha_num > 33 && gotcha_num < 66)
        {
            rare_rate = Rare_rate.B;
        }
        if (gotcha_num > 66 && gotcha_num < 100)
        {
            rare_rate = Rare_rate.C;
        }
        HeroSet();
    }

    void HeroSet()
    {
        switch(rare_rate)
        {
            case Rare_rate.S:
                int select_num = 0;
                select_num = Random.Range(0, summon.s_rank_hero.Count-1);
                //print($"{select_num} , s 랭크");
                result_hero = summon.s_rank_hero[select_num];
                break;
            case Rare_rate.A:
                select_num = Random.Range(0, summon.a_rank_hero.Count-1);
                //print($"{select_num} , a 랭크");
                result_hero = summon.a_rank_hero[select_num];
                break;
            case Rare_rate.B:
                select_num = Random.Range(0, summon.b_rank_hero.Count-1);
                //print($"{select_num} , b 랭크");
                result_hero = summon.b_rank_hero[select_num];
                break;
            case Rare_rate.C:
                select_num = Random.Range(0, summon.c_rank_hero.Count-1);
                //print($"{select_num} , c 랭크");
                result_hero = summon.c_rank_hero[select_num];
                break;
        }
        inventory.SendMessage("AddHero",result_hero);
        popup.SetActive(true);
        popup.GetComponent<PopUp>().SetOn("획득",result_hero.GetComponent<CharacterInfo>().illust);
        rare_rate = Rare_rate.none;
    }
}
