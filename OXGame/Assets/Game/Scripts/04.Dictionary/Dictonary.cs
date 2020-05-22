using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dictonary : MonoBehaviour
{
    public GameObject upgrade_card;
    UpgradeCard upgrade;

    public GameObject my_inventory;
    public Inventory _inventory;

    public GameObject[] slot = new GameObject[4];

    private void Awake()
    {
        _inventory = my_inventory.GetComponent<Inventory>();
    }

    private void OnEnable()
    {
        for(int i =0; i< _inventory.my_hero_list.Count;i++)
        {
            slot[i].SetActive(true);
            slot[i].GetComponent<Button>().interactable = true;
            slot[i].GetComponent<DicSlot>().hero = _inventory.my_hero_list[i];
        }
    }

 
}
