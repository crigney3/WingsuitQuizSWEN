using UnityEngine;


public class EndgameScript : MonoBehaviour
{
    public GameObject EndgameFeedBack;
    public bool[] questions;

    public void OnCollisionEnter(Collision collision)
    {
        EndgameFeedBack.SetActive(true);
    }
}
