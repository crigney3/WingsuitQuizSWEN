using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject gameManager;
    GameManagerScript gm;
    public bool correct;
    public int questionNum;
    // Start is called before the first frame update
    void Start()
    {
        gm = gameManager.GetComponent<GameManagerScript>();
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
        }
        else
        {
            Debug.Log("Incorrect");
        }
    }
}
