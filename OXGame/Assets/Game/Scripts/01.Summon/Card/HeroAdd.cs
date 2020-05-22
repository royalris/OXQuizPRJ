using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAdd : MonoBehaviour
{
    public List<GameObject> want_to_add = new List<GameObject>();


    private Summon summon;

    private void Awake()
    {
        summon = transform.GetComponent<Summon>();
    }

    private void Start()
    {
        if (!CheckComponent())
        {
            Debug.Break();
        }
        else
        {
            Sort();
        }
    }

    bool CheckComponent() //넣은 오브젝트에 분명하게 정보 클래스가 붙어 있는지
    {
        bool all_complite = true;

        for (int i = 0; i < want_to_add.Count; i++)
        {
            try
            {
                want_to_add[i].GetComponent<CharacterInfo>();
            }
            catch
            {
                all_complite = false;
                Debug.LogError($"{i}번째 게임오브젝트에는 CharacterInfo 스크립트가 존재하지 않습니다");
            }
        }
        return all_complite;
    }



    private void Sort()
    {
        List<GameObject> s_rank_hero = new List<GameObject>();
        List<GameObject> a_rank_hero = new List<GameObject>();
        List<GameObject> b_rank_hero = new List<GameObject>();
        List<GameObject> c_rank_hero = new List<GameObject>();

        for (int i = 0; i < want_to_add.Count; i++)
        {
            GameObject add_hero;
            add_hero = want_to_add[i];
            switch (want_to_add[i].GetComponent<CharacterInfo>().rank)
            {
                case 0:
                    s_rank_hero.Add(add_hero);
                    break;          
                case 1:             
                    a_rank_hero.Add(add_hero);
                    break;          
                case 2:             
                    b_rank_hero.Add(add_hero);
                    break;          
                case 3:             
                    c_rank_hero.Add(add_hero);
                    break;
            }
        }
        summon.GetHeroList(s_rank_hero,
                         a_rank_hero,
                        b_rank_hero,
                         c_rank_hero);
    }
}