using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // �������� ��� ������

public class Click_Open : MonoBehaviour
{
   // public TextMeshProUGUI text_1;


    void Start()
    {

    }

    public void PressButton()
    {
        //text_1.text = "��� ����"; // text � ��������� �����!

        SceneManager.LoadScene("New");

    }
}