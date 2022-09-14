using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceDisplay : MonoBehaviour
{
    public Dice dice;
    public TextMeshProUGUI DicePoint;
    public Image image;

    private Sprite One;
    private Sprite Two;
    private Sprite Three;
    private Sprite Four;
    private Sprite Five;
    private Sprite Six;

    // Start is called before the first frame update
    void Start()
    {
        One = Resources.Load<Sprite>("Selfmade element/Dice/Dice1");
        Two = Resources.Load<Sprite>("Selfmade element/Dice/Dice2");
        Three = Resources.Load<Sprite>("Selfmade element/Dice/Dice3");
        Four = Resources.Load<Sprite>("Selfmade element/Dice/Dice4");
        Five = Resources.Load<Sprite>("Selfmade element/Dice/Dice5");
        Six = Resources.Load<Sprite>("Selfmade element/Dice/Dice6");
        ShowDice();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowDice()
    {
        DicePoint.text = dice.Point.ToString();
        switch(dice.Point)
        {
            case 1:
                image.sprite = One;
                break;
            case 2:
                image.sprite = Two;
                break;
            case 3:
                image.sprite = Three;
                break;
            case 4:
                image.sprite = Four;
                break;
            case 5:
                image.sprite = Five;
                break;
            case 6:
                image.sprite = Six;
                break;
            default:
                break;
        }
    } 
}