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
        // ������� ������ ������ ����� ������ ������������
        if (isButtonHeld && targetModel != null)
        {
            targetModel.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }

    // ���������� ����� �������� �� ������
    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonHeld = true;
    }

    // ���������� ����� ��������� ������
    public void OnPointerUp(PointerEventData eventData)
    {
        isButtonHeld = false;
    }
}




