using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Добавьте эту строку

public class Click_Open : MonoBehaviour
{
   // public TextMeshProUGUI text_1;


    void Start()
    {

    }

    public void PressButton()
    {
        //text_1.text = "Моя игра"; // text с маленькой буквы!

        SceneManager.LoadScene("New");

    }
}