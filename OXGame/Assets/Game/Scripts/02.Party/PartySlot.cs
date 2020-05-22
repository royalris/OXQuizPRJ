using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartySlot : MonoBehaviour
{
    
    public GameObject party;
    public GameObject hero;

    public void Setting(GameObject hero)
    {
        party.SendMessage("Refresh");
    }
}
