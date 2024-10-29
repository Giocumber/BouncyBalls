using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHoverScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 increaseScale;

    private RectTransform rectTransform;
    private Vector3 originalScale;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalScale = rectTransform.localScale;
    }

    public void OnPointerEnter()
    {
        rectTransform.localScale = increaseScale;
    }

    public void OnPointerExit()
    {
        rectTransform.localScale = originalScale;
    }
}
