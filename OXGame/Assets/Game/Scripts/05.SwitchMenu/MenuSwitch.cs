using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSwitch : MonoBehaviour
{
    [Header("메뉴 전환 스크립트")]
    [Tooltip("메인 메뉴 버튼")]
    public Button mainmenu_btn;
    [Tooltip("파티 설정 메뉴 버튼")]
    public Button party_btn;
    [Tooltip("도감 메뉴 버트")]
    public Button dicitonary_btn;
    [Tooltip("뽑기 메뉴 버튼")]
    public Button summon_btn;

    private Button[] buttons;

    [Space (15)]
    [Header ("끄고 킬 패널들")]
    [Tooltip("메인 메뉴 패널")]
    public GameObject mainmenu_panel;
    [Tooltip("파티 설정 메뉴 패널")]
    public GameObject party_panel;
    [Tooltip("도감 메뉴 패널")]
    public GameObject dicitonary_panel;
    [Tooltip("뽑기 메뉴 패널")]
    public GameObject summon_panel;

    private GameObject[] panels; //패널을 한번에 관라히기 위해 넣어줄 배열


    private void Awake()
    {
        buttons = new Button[4] { mainmenu_btn, party_btn,dicitonary_btn,summon_btn};
        panels = new GameObject[4] { mainmenu_panel, party_panel, dicitonary_panel, summon_panel };

        ButtonSet();
    }

    private void ButtonSet()//버튼의 기능 동적 할당
    {
        mainmenu_btn.onClick.AddListener(GotoMainMenu);
        party_btn.onClick.AddListener(GotoParty);
        dicitonary_btn.onClick.AddListener(GotoDictionary);
        summon_btn.onClick.AddListener(GotoGotcha);
    }

    private void Start()
    {
        GotoMainMenu(); //게임을 시작 했으 때는 처음에는 무조건 메인메뉴가 나오도록 설정한다
    }

    public void GotoMainMenu() //동적할당 리스너에 들어가는 인수는 이벤트 함수명 하나만을 인수로 받기 때문에 인자 값을 이용한 노가다 줄이기를 할수 가 없었다
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (i == 0)
            {
                panels[i].SetActive(true);
                buttons[i].interactable = false;
            }
            else
            {
                panels[i].SetActive(false);
                buttons[i].interactable = true;
            }
        }
    }
    public void GotoParty()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (i == 1)
            {
                panels[i].SetActive(true);
                buttons[i].interactable = false;
            }
            else
            {
                panels[i].SetActive(false);
                buttons[i].interactable = true;
            }
        }
    }
    public void GotoDictionary()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (i == 2)
            {
                panels[i].SetActive(true);
                buttons[i].interactable = false;
            }
            else
            {
                panels[i].SetActive(false);
                buttons[i].interactable = true;
            }
        }
    }
    public void GotoGotcha()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (i == 3)
            {
                panels[i].SetActive(true);
                buttons[i].interactable = false;
            }
            else
            {
                panels[i].SetActive(false);
                buttons[i].interactable = true;
            }
        }
    }
}
