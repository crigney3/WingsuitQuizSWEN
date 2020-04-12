using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FlightController : MonoBehaviour
{
    GameObject f;
    // Start is called before the first frame update
    void Start()
    {
        f = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            f.transform.position += new Vector3(0, 0.1f, 0);
        }else if (Input.GetKey(KeyCode.E))
        {
            f.transform.position += new Vector3(0, -0.1f, 0);
        }
    }
}
