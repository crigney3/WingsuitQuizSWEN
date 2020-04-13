using UnityEngine;

public class FeedbackSript : MonoBehaviour
{
    public GameObject feedbackWindow;

    public void OnCollisionEnter(Collision collision)
    {
        feedbackWindow.SetActive(true);
    }
}
