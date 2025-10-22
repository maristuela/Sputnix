using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Должен быть в начале файла

public class SimpleButtonColor : MonoBehaviour
{
    [Header("Цвета кнопки Button")]
    public Color[] buttonColors = {
        new Color(1f, 0.5f, 0.5f), // светло-красный
        new Color(0.5f, 1f, 0.5f), // светло-зеленый
        new Color(0.5f, 0.5f, 1f), // светло-синий
        new Color(1f, 1f, 0.5f)   // светло-желтый
    };

    private int colorIndex = 0;

    void Start()
    {
        // Назначаем обработчик нажатия
        GetComponent<Button>()?.onClick.AddListener(OnButtonClick);
    }

    /*  private void OnButtonClick()
      {
          if (buttonColors.Length == 0) return;

          // Меняем цвет изображения кнопки Button
          Image image = GetComponent<Image>();
          if (image != null)
          {
              colorIndex = (colorIndex + 1) % buttonColors.Length;
              image.color = buttonColors[colorIndex];
          }
          SceneManager.LoadScene("AR");
      }*/


    private void OnButtonClick()
    {
        SceneManager.LoadScene("AR");
    }

    private void OnDestroy()
    {
        GetComponent<Button>()?.onClick.RemoveListener(OnButtonClick);
    }
}