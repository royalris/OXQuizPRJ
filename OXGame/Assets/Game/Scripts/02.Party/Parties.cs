using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parties : MonoBehaviour
{

    public Inventory invetory;

    public List<GameObject> wating_slots = new List<GameObject>();
    public List<GameObject> wating_heroes = new List<GameObject>();

    private void OnEnable()
    {
        RecallMyHeroList();
    }


    public void RecallMyHeroList()
    {
        int my_hero_count = invetory.my_hero_list.Count;

        for (int i = 0; i < my_hero_count; i++)
        {
            wating_slots[i].SetActive(true);
            wating_heroes[i] = invetory.my_hero_list[i];
        }
    }



    private void OnDisable()
    {
        int my_hero_count = invetory.my_hero_list.Count;
        for (int i = 0; i < my_hero_count; i++)
        {
            wating_slots[i].SetActive(false);
        }
        wating_heroes.Clear();
    }

}
