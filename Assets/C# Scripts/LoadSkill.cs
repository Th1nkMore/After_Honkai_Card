using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSkill : MonoBehaviour
{   
    public TextAsset SkillData;
    public List<Skill> Skilllist = new List<Skill>();
    // Start is called before the first frame update
    void Start()
    {
        LoadSkills();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadSkills()
    {
        string[] DataRow = SkillData.text.Split('\n');
        foreach (string row in DataRow)
        {
            string[] elements = row.Split(',');
            string name = elements[0];
            string description = elements[1];
            string Cosume = elements[2];
            int Damage = int.Parse(elements[3]);
            int Cure = int.Parse(elements[4]);
            Skill skill = new Skill(name, Cosume, Damage, Cure, description);
            Skilllist.Add(skill);
            // Debug.Log("Loading " + skill.name + "…");
        }

    }
    public Skill RandomSkill()
    {
        return Skilllist[Random.Range(0, Skilllist.Count)];
    }
}
