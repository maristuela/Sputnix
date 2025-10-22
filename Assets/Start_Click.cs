using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // ������ ���� � ������ �����

public class SimpleButtonColor : MonoBehaviour
{
    [Header("����� ������ Button")]
    public Color[] buttonColors = {
        new Color(1f, 0.5f, 0.5f), // ������-�������
        new Color(0.5f, 1f, 0.5f), // ������-�������
        new Color(0.5f, 0.5f, 1f), // ������-�����
        new Color(1f, 1f, 0.5f)   // ������-������
    };

    private int colorIndex = 0;

    void Start()
    {
        // ��������� ���������� �������
        GetComponent<Button>()?.onClick.AddListener(OnButtonClick);
    }

    /*  private void OnButtonClick()
      {
          if (buttonColors.Length == 0) return;

          // ������ ���� ����������� ������ Button
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