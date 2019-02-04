using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bandSensor : MonoBehaviour {
    bool triggered;
    private Renderer rend;

    // Use this for initialization
    void Start () {
        triggered = false;
        rend = GetComponent<Renderer>();
        rend.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (triggered == false && (collision.name == "RSpot" || collision.name == "LSpot"))
        {
            rend.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;
        rend.enabled = false;
    }
}
