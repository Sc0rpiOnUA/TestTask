using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel;
 


    public void Start()
    {
        _settingsPanel.SetActive(false);

        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void SettingsOpenButton()
    {
        _settingsPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void SettingsCloseButton()
    {
        _settingsPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void SoundOnButton()
    {

    }
    public void SoundOffButton()
    {

    }

    public void SoundSettingsOpenButton()
    {
        _settingsPanel.SetActive(true);
        
    }
    public void SoundSettingsCloseButton()
    {
        _settingsPanel.SetActive(false);

    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
