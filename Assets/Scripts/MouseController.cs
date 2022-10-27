using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    [SerializeField] Camera _playerCamera;
    private float localXRotation;
    private float xRotCurrent, yRotCurrent;
    [SerializeField] private float _mouseSensivity;
    [SerializeField] GameObject _playerGO;

    private void Awake()
    {
        localXRotation = 0f;
    }

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }


    void FixedUpdate()
    {
        MouseMove();
    }

    private void MouseMove()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensivity * Time.deltaTime;

        localXRotation -= mouseY;
        localXRotation = Mathf.Clamp(localXRotation, -90f, 90f);

        _playerGO.transform.Rotate(Vector3.up * mouseX);
        _playerCamera.transform.localRotation = Quaternion.Euler(localXRotation, 0f, 0f);
    }
}
