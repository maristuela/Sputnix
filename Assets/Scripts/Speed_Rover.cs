using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Speed_Rover : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [Header("Rover Model")]
    public GameObject roverModel; // ���������� ����������

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
        // ������� ������ ������ ����� ������ ������������
        if (isMoving && roverModel != null)
        {
            // �������� ������ ������������ �������� ����������� ������
            roverModel.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.Self);
        }
    }

    // ���������� ����� �������� �� ������
    public void OnPointerDown(PointerEventData eventData)
    {
        isMoving = true;
    }

    // ���������� ����� ��������� ������
    public void OnPointerUp(PointerEventData eventData)
    {
        isMoving = false;
    }
}