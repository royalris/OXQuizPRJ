using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject buttons;
    public GameObject slotmachine;
    public void StartGame()
    {
        MainMenuPanel.SetActive(false);
        buttons.SetActive(false);
        slotmachine.SetActive(true);
        slotmachine.SendMessage("SetCategory");
        this.gameObject.SetActive(false);
    }
}