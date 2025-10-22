using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    void Start()
    {

    }

    [Header("Model to Rotate")]
    public GameObject targetModel;

    [Header("Rotation Settings")]
    public float rotationSpeed = 30f;

    private bool isButtonHeld = false;

    void Update()
    {
        // Вращаем модель только когда кнопка удерживается
        if (isButtonHeld && targetModel != null)
        {
            targetModel.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }

    // Вызывается когда нажимают на кнопку
    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonHeld = true;
    }

    // Вызывается когда отпускают кнопку
    public void OnPointerUp(PointerEventData eventData)
    {
        isButtonHeld = false;
    }
}




