using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Card : MonoBehaviour
{
    public Attack AttackValue;
    public CardPlayer player;    
    public Vector2 OriginalPosition;
    Vector2 OriginalScale;
    Color OriginalColor;
    bool isClickable = true;
    private void Start(){
        OriginalPosition = this.transform.position;
        OriginalScale = this.transform.localScale;
        OriginalColor = GetComponent<Image>().color;
    }
    public void OnClick()
    {
        if (isClickable){
            transform.position = OriginalPosition;
            player.SetChosenCard(this);
        }
    }
    
    internal void Reset()
    {
        transform.position = OriginalPosition;
        transform.localScale = OriginalScale;
        GetComponent<Image>().color = OriginalColor;
    }
    public void SetClickable(bool value)
    {
        isClickable = value;
    }
}
