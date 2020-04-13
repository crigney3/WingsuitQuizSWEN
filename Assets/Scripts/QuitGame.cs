using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void quit()
    {
        Application.Quit();
    }

    public void ButtonMoveScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
