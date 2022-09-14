using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DiceSelected : MonoBehaviour, IPointerDownHandler
{
    public Image isSelected;
    private bool select = false;
    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        select = !select;
        int Point = this.GetComponent<DiceDisplay>().dice.Point;
        isSelected.gameObject.SetActive(select);
    }

}
