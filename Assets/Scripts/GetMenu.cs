using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ������ ��� ������

public class GetMenu : MonoBehaviour
{
    public GameObject scrollViewObject; // ������������ ����������

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PressButton()
    {
        //text_1.text = "��� ����"; // text � ��������� �����!
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