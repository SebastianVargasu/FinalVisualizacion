using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponChanger : MonoBehaviour
{
    [SerializeField] private List<buttonHover> buttonsW;
    [SerializeField] private Image stadisticsDisplay;
    [SerializeField] private List<Sprite> stadisticsSprites;

    private void Start() {
        WeaponerChangers(0);
    }

    public void WeaponerChangers(int stadistics)
    {
        switch (stadistics)
        {
            case 0:
                stadisticsDisplay.sprite = stadisticsSprites[0];
                buttonsW[0].HoverButton();
                buttonsW[1].UnhoverButton();
                //buttonsW[2].UnhoverButton();
                break;
            case 1:
                stadisticsDisplay.sprite = stadisticsSprites[1];
                buttonsW[0].UnhoverButton();
                buttonsW[1].HoverButton();
               // buttonsW[2].UnhoverButton();
                break;
            case 2:
                stadisticsDisplay.sprite = stadisticsSprites[2];
                buttonsW[0].UnhoverButton();
                buttonsW[1].UnhoverButton();
                //buttonsW[2].HoverButton();
                break;
        }
    }
}
