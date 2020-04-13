using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerScript : MonoBehaviour
{
    public GameObject gameManager;
    GameObject feedbackWindow;
    GameManagerScript gm;
    public Text txt;
    public bool correct;
    public int questionNum;
    // Start is called before the first frame update
    void Start()
    {
        gm = gameManager.GetComponent<GameManagerScript>();
        txt = gm.txt;
        feedbackWindow = gm.feedbackWindow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider c)
    {
        if (correct)
        {
            Debug.Log(questionNum);
            gm.setQuestion(questionNum, true);
            txt.text = "Correct!";
        }
        else
        {
            Debug.Log("Incorrect");
            txt.text = "Incorrect";
        }
        feedbackWindow.SetActive(true);       
    }
}
