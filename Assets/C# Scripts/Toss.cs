using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toss : MonoBehaviour
{   
    public GameObject DicePrefab;
    private List<GameObject> Dices = new List<GameObject>();
    // private float startPoint = -700.0f;
    // private float step;
    public Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickToss()
    {
        ClearDices();
        for (int i = 0; i < 8; i++)
        {
            GameObject newDice = GameObject.Instantiate(DicePrefab, canvas);
            // newDice.transform.localPosition = new Vector2(startPoint + step * i, 0.0f);
            Dices.Add(newDice);
            newDice.GetComponent<DiceDisplay>().dice = new Dice(Random.Range(1, 7));

        }
    }
    public void ClearDices()
    {
        foreach (var dice in Dices)
        {
            Destroy(dice);
        }
        Dices.Clear();
    }
}
