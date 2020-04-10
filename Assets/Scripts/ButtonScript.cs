using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public void OnMouseUp()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void OnMouseEnter()
    {
        this.GetComponent<Text>().color = Color.black;
    }

    public void OnMouseExit()
    {
        this.GetComponent<Text>().color = Color.white;
    }
}
