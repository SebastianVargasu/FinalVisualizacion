using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StadisticsChanger : MonoBehaviour
{
    [SerializeField] private List<buttonHover> buttons;
    [SerializeField] private Image stadisticsDisplay;
    [SerializeField] private List<Sprite> stadisticsSprites;

    private void Start() {
        ChangeStadistics(0);
    }

    public void ChangeStadistics(int stadistics)
    {
        switch (stadistics)
        {
            case 0:
                stadisticsDisplay.sprite = stadisticsSprites[0];
                buttons[0].HoverButton();
                buttons[1].UnhoverButton();
                buttons[2].UnhoverButton();
                break;
            case 1:
                stadisticsDisplay.sprite = stadisticsSprites[1];
                buttons[0].UnhoverButton();
                buttons[1].HoverButton();
                buttons[2].UnhoverButton();
                break;
            case 2:
                stadisticsDisplay.sprite = stadisticsSprites[2];
                buttons[0].UnhoverButton();
                buttons[1].UnhoverButton();
                buttons[2].HoverButton();
                break;
        }
    }
}
