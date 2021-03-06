﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRSpot : MonoBehaviour {
    public float movementSpeed;
    private Renderer rend;
    private AudioSource sound;
    private Rigidbody2D rb;
    private bool moving;
    private GameObject music;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>();
        moving = false;
        music = GameObject.Find("GameController");

        rend = GetComponent<Renderer>();
        rend.enabled = false;
        StartCoroutine(ShowTime());
    }

    void FixedUpdate()
    {
        if (moving)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(Vector3.left * movementSpeed);
                rb.velocity = Vector3.zero;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(Vector3.right * movementSpeed);
                rb.velocity = Vector3.zero;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(Vector3.up * movementSpeed);
                rb.velocity = Vector3.zero;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(Vector3.down * movementSpeed);
                rb.velocity = Vector3.zero;
            }

            Vector3 oldPosition = gameObject.transform.position;
            Vector3 newPosition = oldPosition;

            //it's Min of right,  top bounds
            //it's a Max of left, bottom bounds.
            newPosition.x = Mathf.Min(oldPosition.x, 33);
            newPosition.x = Mathf.Max(newPosition.x, -33);
            newPosition.y = Mathf.Min(oldPosition.y, 17);
            newPosition.y = Mathf.Max(newPosition.y, -14);

            gameObject.transform.position = newPosition;
        }
    }

    IEnumerator ShowTime()
    {
        yield return new WaitForSeconds(3.5f);
        rend.enabled = true;
        sound.Play();
        moving = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "band")
        {
            music.GetComponent<GameController>().turnRightOn();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

            music.GetComponent<GameController>().turnRightOff();

    }
}
