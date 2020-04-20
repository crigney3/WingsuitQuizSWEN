using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    /*public GameObject GoalRed;
    public GameObject GoalBlue;
    public GameObject GoalGreen;
    public GameObject GoalYellow;
    public GameObject Sign;*/
    public GameObject player;
    public GameObject questionPlatform;
    public GameObject platform;
    public int questionAmount;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gm = GameObject.Find("GameManager");
        Vector3 initPos = player.transform.position + new Vector3(-4, -10, 25);
        int i = 0;
        for(i = 0; i < questionAmount; i++)
        {
            Vector3 position = initPos + (i * new Vector3(0, -20, 20));

            GameObject newPlatform = Instantiate(questionPlatform, position, Quaternion.identity);

            newPlatform.transform.GetChild(0).transform.GetChild(4).GetComponent<TriggerScript>().questionNum = i;
            newPlatform.transform.GetChild(1).transform.GetChild(4).GetComponent<TriggerScript>().questionNum = i;
            newPlatform.transform.GetChild(2).transform.GetChild(4).GetComponent<TriggerScript>().questionNum = i;
            newPlatform.transform.GetChild(3).transform.GetChild(4).GetComponent<TriggerScript>().questionNum = i;

            newPlatform.transform.GetChild(0).transform.GetChild(4).GetComponent<TriggerScript>().gameManager = gm;
            newPlatform.transform.GetChild(1).transform.GetChild(4).GetComponent<TriggerScript>().gameManager = gm;
            newPlatform.transform.GetChild(2).transform.GetChild(4).GetComponent<TriggerScript>().gameManager = gm;
            newPlatform.transform.GetChild(3).transform.GetChild(4).GetComponent<TriggerScript>().gameManager = gm;

            //Old method of creating questions, no longer needed
            /*Instantiate(Platform, position, Quaternion.identity);
            Instantiate(Sign, new Vector3(position.x, position.y, position.z + 20), Quaternion.identity);
            Instantiate(GoalBlue, new Vector3(position.x - 20, position.y + 5, position.z + 20), Quaternion.identity);
            Instantiate(GoalRed, new Vector3(position.x - 5, position.y + 5, position.z + 20), Quaternion.identity);
            Instantiate(GoalGreen, new Vector3(position.x + 5, position.y + 5, position.z + 20), Quaternion.identity);
            Instantiate(GoalYellow, new Vector3(position.x + 20, position.y + 5, position.z + 20), Quaternion.identity);*/
        }

        Instantiate(platform, initPos + (i * new Vector3(0, -20, 20)) + new Vector3(0,0,-30), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
