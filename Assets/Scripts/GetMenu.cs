using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Добавь эту строку

public class GetMenu : MonoBehaviour
{
    public GameObject scrollViewObject; // Переименовал переменную

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PressButton()
    {
        //text_1.text = "Моя игра"; // text с маленькой буквы!
        //SceneManager.LoadScene("AR");

        if (scrollViewObject != null)
        {
            scrollViewObject.SetActive(!scrollViewObject.activeSelf);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}