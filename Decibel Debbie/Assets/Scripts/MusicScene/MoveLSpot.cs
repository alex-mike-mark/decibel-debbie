using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLSpot : MonoBehaviour {
    public float movementSpeed;
    private Renderer rend;
    private AudioSource sound;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>();


        rend = GetComponent<Renderer>();
        rend.enabled = false;
        StartCoroutine(ShowTime());
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * movementSpeed);
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * movementSpeed);
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.up * movementSpeed);
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.down * movementSpeed);
            rb.velocity = Vector3.zero;
        }

        Vector3 oldPosition = gameObject.transform.position;
        Vector3 newPosition = oldPosition;

        //it's Min of right,  top bounds
        //it's a Max of left, bottom bounds.
        newPosition.x = Mathf.Min(oldPosition.x,33);
        newPosition.x = Mathf.Max(newPosition.x,-33);
        newPosition.y = Mathf.Min(oldPosition.y,17);
        newPosition.y = Mathf.Max(newPosition.y,-14);

        gameObject.transform.position = newPosition;
    }

    IEnumerator ShowTime()
    {
        yield return new WaitForSeconds(0);
        rend.enabled = true;
        sound.Play();
    }
}
