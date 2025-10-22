using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Speed_Rover : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [Header("Rover Model")]
    public GameObject roverModel; // Объявление переменной

    [Header("Movement Settings")]
    public float moveSpeed = 2f;

    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Двигаем модель только когда кнопка удерживается
        if (isMoving && roverModel != null)
        {
            // Движение вперед относительно текущего направления модели
            roverModel.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.Self);
        }
    }

    // Вызывается когда нажимают на кнопку
    public void OnPointerDown(PointerEventData eventData)
    {
        isMoving = true;
    }

    // Вызывается когда отпускают кнопку
    public void OnPointerUp(PointerEventData eventData)
    {
        isMoving = false;
    }
}