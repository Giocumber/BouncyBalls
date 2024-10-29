using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentScript : MonoBehaviour
{
    private RectTransform rectTransform;

    private void OnEnable()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, -100000);
    }
}
