using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bandSensor : MonoBehaviour {
    bool triggered;
    

    // Use this for initialization
    void Start () {
        triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (triggered == false && (collision.name == "RArm" || collision.name == "LArm"))
        {

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;
    }
}
