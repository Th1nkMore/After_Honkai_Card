using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCard : MonoBehaviour
{
    public TextAsset cardData;
    public List<Card> CharacterCardlist = new List<Card>();
    
    // Start is called before the first frame update
    void Start()
    {
        LoadCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadCharacter()
    {
        // Debug.Log("Loading...");
        string[] DataRow = cardData.text.Split('\n');
        foreach (string row in DataRow)
        {
            string[] elements = row.Split(',');
            string name = elements[0];
            int Health = int.Parse(elements[1]);
            float MissRate = float.Parse(elements[2]);
            int def = int.Parse(elements[3]);
            int atk = int.Parse(elements[4]);
            CharacterCard characterCard = new CharacterCard(name, Health, MissRate, def, atk);
            CharacterCardlist.Add(characterCard);
            Debug.Log("Card Loaded: name is " + characterCard.name);

        }

    }
}
