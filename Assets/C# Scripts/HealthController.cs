using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthController : MonoBehaviour
{
    public Image HealthPoint;
    public TextMeshProUGUI HP;
    public Card card;
    private void Start()
    {
        
        HealthUpdate();
    }
    public void HealthUpdate()
    {
        HealthPoint.rectTransform.localScale = new Vector2(0.5f, 1);

        HP.text = "血量";
    }
}
