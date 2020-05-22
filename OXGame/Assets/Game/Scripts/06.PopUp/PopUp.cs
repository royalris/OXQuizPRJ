using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class PopUp : MonoBehaviour
{
    public Text contents;
    public Image image;

    public  void SetOn(string _contents , Sprite _image)
    {
        contents.text = _contents; image.sprite = _image;
        this.gameObject.SetActive(true);
    }

    public void SetOff()
    {
        this.gameObject.SetActive(false);
    }
}
