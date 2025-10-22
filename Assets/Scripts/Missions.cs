using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Добавьте эту строку

public class Missions : MonoBehaviour
{
    public TextMeshProUGUI text_1;

    private int number = 1;


    void Start()
    {

    }

    public void Minus()
    {
        number--;
        
    }

    public void Plus()
    {
        number++;
       
    }


    public void Start_AR()
    {

        SceneManager.LoadScene("AR");

    }
}