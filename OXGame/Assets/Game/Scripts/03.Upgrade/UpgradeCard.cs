using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCard : MonoBehaviour
{
    public CharacterInfo info;

    public GameObject pick_hero;
    public Image character_image;
    public Text level_textbox;
    public Text name_textbox;
    public Text atk_textbox;
    public Text decribe_textbox;
    public Text needtogupgrade_textbox;
    public Text curr_combine_amount_textbox;
    public Text rank_textbox;

    private Sprite illust_sprite;
    private int level;
    private string _name;
    private float atk;
    private string describe;
    private int needtoupgrade;
    private int curr_combine_amount;
    private int rank;

    public GameObject swtich_obj;
    public Button upgrade_btn;

    public void Refresh(GameObject hero)
    {
        pick_hero = hero;
        info = pick_hero.GetComponent<CharacterInfo>();

        illust_sprite = info.illust;
        level = info.level;
        _name = info.character_name;
        atk = info.curr_atk;
        describe = info.describe;
        curr_combine_amount = info.curr_combined_amount;
        needtoupgrade = info.curr_need_combine_amount;
        rank = info.rank;


        character_image.sprite = illust_sprite;
        level_textbox.text = level.ToString();
        name_textbox.text = _name;
        atk_textbox.text = atk.ToString();
        decribe_textbox.text = describe;
        needtogupgrade_textbox.text = needtoupgrade.ToString();
        curr_combine_amount_textbox.text = curr_combine_amount.ToString();
        switch(rank)
        {
            case 0:
                rank_textbox.text = "S";
                break;
            case 1:
        rank_textbox.text = "A";

                break;case 2:
                rank_textbox.text = "B";

                break;
            case 3:
                rank_textbox.text = "C";

                break;
        }

        if (curr_combine_amount >= needtoupgrade)
        {
            upgrade_btn.interactable = true;
        }
        else
        {
            upgrade_btn.interactable = false;
        }
    }

    public void Cancle()
    {
        this.gameObject.SetActive(false);
    }

    public void Upgarde()
    {
        info.LevelUp();
        Refresh(pick_hero);
    }

    private void OnEnable()
    {
        swtich_obj.SetActive(false);
    }
    private void OnDisable()
    {
        swtich_obj.SetActive(true);
    }
}
