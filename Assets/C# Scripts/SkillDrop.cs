using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SkillDrop : MonoBehaviour, IDropHandler
{
    public int PointUsed;
    public void OnDrop(PointerEventData pointerEventData)
    {
        Skill skill = GetComponent<SkillDisplay>().skill;
        string limitation = skill.Cosume;
        Destroy(pointerEventData.pointerDrag);
    }
}
