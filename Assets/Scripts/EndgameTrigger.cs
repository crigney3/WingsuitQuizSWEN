using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndgameTrigger : MonoBehaviour
{
    public GameObject gameManager;
    GameManagerScript gm;
    public bool endGameCursor;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        gm = gameManager.GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (endGameCursor && !Cursor.visible)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void OnTriggerEnter(Collider c)
    {
        Debug.Log("Triggered Endgame " + gm.getCorrect() + " " + gm.getWrong());

        gm.feedbackWindow.SetActive(false);
        gm.finalFeedback.SetActive(true);

        Text correctAns = gm.finalCorrectTxt;
        Text wrongAns = gm.finalWrongTxt;

        correctAns.text += gm.getCorrect();
        wrongAns.text += " " + gm.getWrong();

        endGameCursor = true;
    }
}
