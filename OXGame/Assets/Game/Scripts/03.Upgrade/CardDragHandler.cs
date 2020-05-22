using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardDragHandler : MonoBehaviour ,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public GameObject clone;
    public Transform mousepos;

    public void OnBeginDrag(PointerEventData eventData)
    {
        clone = gameObject;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        clone.transform.position = transform.position; 
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        clone = null;
    }
}
