using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    int score;
    public int numQuestions;
    public bool[] questions;
    public GameObject questionObject;
    // Start is called before the first frame update
    void Start()
    {
        numQuestions = questionObject.GetComponent<QuestionGenerator>().questionAmount;
        questions = new bool[numQuestions];
        for(int i = 0; i < numQuestions; i++)
        {
            bool a = false;
            questions[i] = a;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setQuestion(int index, bool value)
    {
        Debug.Log("Correct!");
        questions[index] = value;
    }

    public bool getQuestion(int index)
    {      
        return questions[index];
    }
}
