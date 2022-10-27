using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinArea : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;


    public void Start()
    {
        _winPanel.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _winPanel.SetActive(true);
            Time.timeScale = 0;

        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            _winPanel.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;

        }
    }

    public void Update()
    {
        if (_winPanel.activeSelf == true)
            Cursor.lockState = CursorLockMode.None;
    }
}
