using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

  public Image pause;
    public GameObject ui;
    public AudioSource click;

    public void PauseCLicked()
    {
        Toggle();
        
    }

    public void Toggle()
    {
        click.Play();
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void Retry()
    {
        click.Play();
        Toggle();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        click.Play();
        Toggle();
        SceneManager.LoadScene(0);
    }
}
