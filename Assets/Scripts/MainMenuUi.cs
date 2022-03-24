using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUi : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ControlsButton()
    {
        SceneManager.LoadScene(2);
    }
     
    public void ExitButton()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }

    public void AboutButton()
    {
        SceneManager.LoadScene(3);
    }
}
