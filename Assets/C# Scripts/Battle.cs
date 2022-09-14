using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    public LoadSkill loadSkill;
    // Start is called before the first frame update
    void Start()
    {
        loadSkill.LoadSkills();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
