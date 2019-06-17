using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDeactivation : MonoBehaviour
{
    public float FadeTime = 3f;
    public float WaitDelay = 5f;

    private Component currentComponent;
    private Image currentImage;
    private TextMeshProUGUI currentTextMeshUGUI;
    private TextMeshPro currentTextMeshPro;
    private Text currentText;

    private void Start()
    {
        if (GetComponent<Image>())
            currentImage = GetComponent<Image>();
        else if (GetComponent<TextMeshProUGUI>())
            currentTextMeshUGUI = GetComponent<TextMeshProUGUI>();
        else if (GetComponent<Text>())
            currentText = GetComponent<Text>();

        StartCoroutine(FadeIn(WaitDelay));
    }

    private IEnumerator FadeIn(float time)
    {
        if (currentImage != null)
            currentImage.CrossFadeAlpha(1, FadeTime, true);
        else if (currentTextMeshPro != null)
            currentTextMeshPro.CrossFadeAlpha(1, FadeTime, true);
        else if (currentTextMeshUGUI != null)
            currentTextMeshUGUI.CrossFadeAlpha(1, FadeTime, true);
        yield return new WaitForSeconds(time);
        StartCoroutine(FadeOut(WaitDelay));
    }

    private IEnumerator FadeOut(float time)
    {
        yield return new WaitForSeconds(time);
        if (currentImage != null)
            currentImage.CrossFadeAlpha(0, FadeTime, true);
        else if (currentTextMeshPro != null)
            currentTextMeshPro.CrossFadeAlpha(0, FadeTime, true);
        else if (currentTextMeshUGUI != null)
            currentTextMeshUGUI.CrossFadeAlpha(0, FadeTime, true);
    }
}
