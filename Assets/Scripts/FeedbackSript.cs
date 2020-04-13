using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackSript : MonoBehaviour
{
    public GameObject feedbackWindow;
    public Text Text;

    public void OnCollisionEnter(Collision collision, string info)
    {
        feedbackWindow.SetActive(true);
        Text.text = info;
    }
}
