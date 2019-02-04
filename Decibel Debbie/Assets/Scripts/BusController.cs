using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusController : MonoBehaviour {

    public float movementSpeed;
    public float dragSpeed;
    public BusGameController bgc;
    

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.right * dragSpeed);
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * movementSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * movementSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * movementSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.down * movementSpeed);
        }
    }

    void OnTriggerEnter2D(Collider2D coll){
        string tag = coll.gameObject.tag;
        if( tag == "gas"){
            bgc.addGas(10);
        } else if ( tag == "fan" ){
            bgc.addFan();
        }
    }

}