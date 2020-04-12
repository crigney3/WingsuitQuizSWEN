using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public GameObject GoalRed;
    public GameObject GoalBlue;
    public GameObject GoalGreen;
    public GameObject GoalYellow;
    public GameObject Platform;
    public GameObject Sign;
    public GameObject player;
    public int questionAmount;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < questionAmount; i++)
        {
            Vector3 position = player.transform.position + (i * new Vector3(0, -10, 40));
            Instantiate(Platform, position, Quaternion.identity);
            //Instantiate(Sign, new Vector3(position.x, position.y, position.z + 20), Quaternion.identity);
            Instantiate(GoalBlue, new Vector3(position.x - 20, position.y + 5, position.z + 20), Quaternion.identity);
            Instantiate(GoalRed, new Vector3(position.x - 5, position.y + 5, position.z + 20), Quaternion.identity);
            Instantiate(GoalGreen, new Vector3(position.x + 5, position.y + 5, position.z + 20), Quaternion.identity);
            Instantiate(GoalYellow, new Vector3(position.x + 20, position.y + 5, position.z + 20), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
