using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    [SerializeField] Camera _player;
    private float xRotation, yRotation;
    private float xRotCurrent, yRotCurrent;
    private float _mouseSensivity;
    [SerializeField] GameObject _playerGO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MouseMove();
    }

    private void MouseMove()
    {
        xRotation += Input.GetAxis("Mouse X");
        yRotation += Input.GetAxis("Mouse Y");
        _player.transform.rotation = Quaternion.Euler(-yRotation, xRotation, 0);
        _playerGO.transform.rotation = Quaternion.Euler(0, xRotation, 0);
    }
}
