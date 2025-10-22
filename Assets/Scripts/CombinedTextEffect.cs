using System.Collections;
using TMPro;
using UnityEngine;

public class CombinedTextEffect : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public float typeSpeed = 100f;
    public float fadeDuration = 0.25f;

    void Start()
    {
        if (textComponent != null)
        {
            StartCoroutine(AnimateText());
        }
    }

    IEnumerator AnimateText()
    {
        string originalText = textComponent.text;
        textComponent.text = "";
        textComponent.alpha = 0f;

        // Печатаем текст
        for (int i = 0; i <= originalText.Length; i++)
        {
            textComponent.text = originalText.Substring(0, i);

            // Плавно увеличиваем прозрачность
            float alpha = Mathf.Clamp01((float)i / originalText.Length);
            textComponent.alpha = alpha;

            yield return new WaitForSeconds(1f / typeSpeed);
        }

        // Финальный fade-in до полной видимости
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            textComponent.alpha = Mathf.Lerp(textComponent.alpha, 1f, elapsedTime / fadeDuration);
            yield return null;
        }

        textComponent.alpha = 1f;
    }
}
