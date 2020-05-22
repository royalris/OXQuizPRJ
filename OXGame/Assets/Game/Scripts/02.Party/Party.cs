using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Party : MonoBehaviour
{
    //내가 최종적으로 알고 싶은것은 선발된 3명
    public GameObject[] parties = new GameObject[3];

    private Inventory _invetory;

    public List<GameObject> slots = new List<GameObject>();

    public GameObject[] party_slots = new GameObject[3];
    public GameObject[] party_heros = new GameObject[3];

    private void Awake()
    {
        _invetory = transform.GetComponent<Inventory>();
    }

    private void OnEnable()
    {
            if (_invetory.my_hero_list.Count >= 1)
        for (int i = 0; i < _invetory.my_hero_list.Count; i++)
        {
            slots[i].GetComponent<PartyCard>().hero = _invetory.my_hero_list[i];
            slots[i].GetComponent<Image>().sprite = _invetory.my_hero_list[i].GetComponent<CharacterInfo>().illust;
            //slots[i].GetComponent<PartyCard>().Refresh();
        }
    }

    public void Refresh()
    {
        for (int i = 0; i < party_slots.Length; i++)
        {
            if (party_slots[i].GetComponent<PartySlot>().hero != null)
            {
                party_heros[i] = party_slots[i].GetComponent<PartySlot>().hero;
                SendInGameInfo.heroes[i] = party_slots[i].GetComponent<PartySlot>().hero;
            }
        }
    }
}
