using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bandController : MonoBehaviour {
    private bool moving;
    private float timeToChangeDirection;
    private Rigidbody2D rb;
    Renderer rend;

    // Use this for initialization
    public void Start()
    {
        ChangeDirection();
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<Renderer>();
        moving = false;
        StartCoroutine(ShowTime());
    }

    // Update is called once per frame
    public void Update()
    {
        if(moving)
        {
            timeToChangeDirection -= Time.deltaTime;

            if (timeToChangeDirection <= 0)
            {
                ChangeDirection();
            }

            rb.velocity = transform.up * 2;
        }
    }

    private void ChangeDirection()
    {
        float angle = Random.Range(0f, 360f);
        Quaternion quat = Quaternion.AngleAxis(angle, Vector3.forward);
        Vector3 newUp = quat * Vector3.up;
        newUp.z = 0;
        newUp.Normalize();
        transform.up = newUp;
        timeToChangeDirection = 1.5f;
    }

    IEnumerator ShowTime()
    {
        yield return new WaitForSeconds(4);
        moving = true;
    }
}
