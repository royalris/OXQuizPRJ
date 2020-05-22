using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSwitch : MonoBehaviour
{
    public Button mainmenu_btn;
    public Button party_btn;
    public Button dicitonary_btn;
    public Button gotcha_btn;

    public GameObject mainmenu_panel;
    public GameObject party_panel;
    public GameObject dicitonary_panel;
    public GameObject gotcha_panel;

    private void Start()
    {
        GotoMainMenu();
    }

    public void GotoMainMenu()
    {
        mainmenu_panel.SetActive(true);
        party_panel.SetActive(false);
        dicitonary_panel.SetActive(false);
        gotcha_panel.SetActive(false);

        mainmenu_btn.interactable = false;
        party_btn.interactable = true;
        dicitonary_btn.interactable = true;
        gotcha_btn.interactable = true;
    }
    public void GotoParty()
    {
        mainmenu_panel.SetActive(false);
        party_panel.SetActive(true);
        dicitonary_panel.SetActive(false);
        gotcha_panel.SetActive(false);

        mainmenu_btn.interactable = true;
        party_btn.interactable = false;
        dicitonary_btn.interactable = true;
        gotcha_btn.interactable = true;
    }
    public void GotoDictionary()
    {
        mainmenu_panel.SetActive(false);
        party_panel.SetActive(false);
        dicitonary_panel.SetActive(true);
        gotcha_panel.SetActive(false);

        mainmenu_btn.interactable = true;
        party_btn.interactable = true;
        dicitonary_btn.interactable = false;
        gotcha_btn.interactable = true;
    }
    public void GotoGotcha()
    {
        mainmenu_panel.SetActive(false);
        party_panel.SetActive(false);
        dicitonary_panel.SetActive(false);
        gotcha_panel.SetActive(true);

        mainmenu_btn.interactable = true;
        party_btn.interactable = true;
        dicitonary_btn.interactable = true;
        gotcha_btn.interactable = false;
    }
}
