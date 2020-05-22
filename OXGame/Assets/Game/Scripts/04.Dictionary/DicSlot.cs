using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicSlot : MonoBehaviour
{
    public GameObject hero;
    public GameObject upgrade_panel;
    public GameObject upgrade_card;

    public void Upgrade()
    {
        upgrade_panel.SetActive(true);
        upgrade_card.GetComponent<UpgradeCard>().Refresh(hero);
        upgrade_card.SetActive(true);
    }
}
