using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{
    public List<GameObject> s_rank_hero = new List<GameObject>();
    public List<GameObject> a_rank_hero = new List<GameObject>();
    public List<GameObject> b_rank_hero = new List<GameObject>();
    public List<GameObject> c_rank_hero = new List<GameObject>();

    public float[] percentage = new float[4];
    public int require_jewel;
    public GameObject popup;
    private SummonProceedure summon_proceed;
    public GameObject inventory;

    private void Start()
    {
        summon_proceed = new SummonProceedure(this, inventory , popup);
    }

    public void GetHeroList(
        List<GameObject> s,
        List<GameObject> a,
        List<GameObject> b,
        List<GameObject> c
        )
    {
        s_rank_hero = s;
        a_rank_hero = a;
        b_rank_hero = b;
        c_rank_hero = c;
    }


    public void SummonHero()
    {
        summon_proceed.Summon();
    }
}
