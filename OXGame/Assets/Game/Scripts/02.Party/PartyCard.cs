using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Drawing;
using UnityEngine.UI;

public class PartyCard : MonoBehaviour, IPointerDownHandler ,IPointerUpHandler
{
    public GameObject hero;
    CharacterInfo info;

    private GameObject clone;
    public bool syns = false;
    public GameObject[] slot = new GameObject[3];

    public Image hero_image;


    public void Start()
    {
        clone = transform.GetChild(0).gameObject;
    }

    public void Update()
    {
        if(syns == true)
        {
            clone.transform.position = Input.mousePosition;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (hero != null)
        {
            syns = true;
            clone.SetActive(true);
            clone.GetComponent<Image>().sprite = hero.GetComponent<CharacterInfo>().illust;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (hero != null)
        {
            syns = false;
            clone.SetActive(false);
            for (int i = 0; i < 3; i++)
            {
                if (InsertionWith(clone, slot[i]))
                {
                    slot[i].GetComponent<PartySlot>().hero = clone;
                    slot[i].GetComponent<Image>().sprite = clone.GetComponent<Image>().sprite;
                    return;
                }
            }
        }
    }

    public bool InsertionWith(GameObject clone_object, GameObject insertion_obj)
    {
        bool accept = false;
        RectangleF c = new RectangleF(new PointF(clone_object.transform.position.x, clone_object.transform.position.y) ,new SizeF(50,50));
        RectangleF d = new RectangleF(new PointF(insertion_obj.transform.position.x, insertion_obj.transform.position.y), new SizeF(50,50));
        RectangleF e = RectangleF.Intersect(c,d);
        if (e.Width >= d.Width / 2)
        {
            print("5할 이상 중복됨");
            print(insertion_obj);
            accept = true;
        }
        return accept;
    }
}
