using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinController : MonoBehaviour
{
    public List<Sprite> _skins;


    public void Awake()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = _skins[GameCore.Instance.GetSkinNum()];
    }

    public void StandartSkin()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = _skins[0];
        GameCore.Instance.SetSkinNum(0);

    }
    public void RainbowSkin()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = _skins[1];
        GameCore.Instance.SetSkinNum(1);

    }
    public void IcySkin()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = _skins[2];
        GameCore.Instance.SetSkinNum(2);

    }
    

}
