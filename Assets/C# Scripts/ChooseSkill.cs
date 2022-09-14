using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSkill : MonoBehaviour
{
    public GameObject SkillPrefab;
    private List<GameObject> Skills = new List<GameObject>();
    private float startPoint = -700.0f;
    private float step;
    public Transform canvas;
    public LoadSkill LoadSkill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickChoose()
    {
        ClearSkills();
        for (int i = 0; i < 4; i++)
        {
            GameObject newSkill = GameObject.Instantiate(SkillPrefab, canvas);
            newSkill.transform.localPosition = new Vector2(startPoint + step * i, 0.0f);
            Skills.Add(newSkill);
            newSkill.GetComponent<SkillDisplay>().skill = LoadSkill.RandomSkill();
        }
    }
    public void ClearSkills()
    {
        foreach (var skill in Skills)
        {
            Destroy(skill);
        }
        Skills.Clear();
    }
}
