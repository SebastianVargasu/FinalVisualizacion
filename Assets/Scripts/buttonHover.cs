using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonHover : MonoBehaviour
{
    [SerializeField] private Image buttonDisplay;
    [SerializeField] private Sprite normalSprite;
    [SerializeField] private Sprite hoverSprite;
    private bool isHovered;
     
    public void HoverButton(){
        buttonDisplay.sprite = hoverSprite;
        isHovered = true;
    }

    public void UnhoverButton(){
        buttonDisplay.sprite = normalSprite;
        isHovered = false;
    }
}
