using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SkillDisplay : MonoBehaviour
{
    public Skill skill;
    public TextMeshProUGUI Description;
    public TextMeshProUGUI Point;
    public TextMeshProUGUI Name;
    // Start is called before the first frame update
    void Start()
    {
        
        SkillShow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SkillShow()
    {
        Name.text = skill.name;
        Description.text = skill.Description;
        Point.text = skill.Cosume;
    }
}
