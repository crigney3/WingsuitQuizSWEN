using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void ButtonMoveScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
