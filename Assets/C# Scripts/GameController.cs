using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GamePhase
{
    playerDraw, playerAction, enemyAction, gameStart
}
public class GameController : MonoBehaviour
{
    
    private CharacterCard characterCard;
    private MonsterCard monsterCard;
    private List<GameObject> skillpool = new List<GameObject>();
    private List<GameObject> Dices = new List<GameObject>();
    [SerializeField] private GameObject DicePrefab;
    [SerializeField] private GameObject SkillPrefab;
    [SerializeField] private Transform DiceTrans;
    void Start()
    {
        GenerateDices(8);
        characterCard = new CharacterCard("Eden", 100, 0f, 20, 40);
        monsterCard = new MonsterCard("cheche", 50, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void GenerateDices(int number)
    {
        ClearDices();
        for (int i = 0; i < number; i++)
        {
            GameObject newDice = GameObject.Instantiate(DicePrefab, DiceTrans);
            Dices.Add(newDice);
            newDice.GetComponent<DiceDisplay>().dice = new Dice(Random.Range(1, 7));
        }
    }
    private void ClearDices()
    {
        foreach (var dice in Dices)
        {
            Destroy(dice);
        }
        Dices.Clear();
    }
}
