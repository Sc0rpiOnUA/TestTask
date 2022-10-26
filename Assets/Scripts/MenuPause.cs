using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    [SerializeField] KeyCode _keyCode;
    [SerializeField] GameObject _gameMenuPanel;

    void Start()
    {
        _gameMenuPanel.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            _gameMenuPanel.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
    public void BackToGameButton()
    {
        _gameMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
