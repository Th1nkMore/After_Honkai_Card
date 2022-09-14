using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiceDrag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    [SerializeField]private Vector2 StartPos;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        StartPos = rectTransform.anchoredPosition;
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnDrag(PointerEventData pointerEventData)
    {
        rectTransform.anchoredPosition += pointerEventData.delta;
    }
    public void OnBeginDrag(PointerEventData pointerEventData)
    {
        canvasGroup.blocksRaycasts = false;
        StartPos = rectTransform.anchoredPosition;
    }
    public void OnEndDrag(PointerEventData pointerEventData)
    {
        canvasGroup.blocksRaycasts = true;
        rectTransform.anchoredPosition = StartPos;
    }
}
