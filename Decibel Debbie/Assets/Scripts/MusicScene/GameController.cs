using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool leftOn;
    private bool rightOn;

    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        leftOn = false;
        rightOn = false;
        StartCoroutine(ShowTime());
    }

    // Update is called once per frame
    void Update()
    {
        if (leftOn && rightOn)
        {
            sound.panStereo = 0;
            sound.pitch = 1;
            sound.volume = 1;
        }
        else if (leftOn)
        {
            sound.panStereo = -1;
            sound.pitch = 0.99f;
            sound.volume = 0.8f;
        }
        else if (rightOn)
        {
            sound.panStereo = 1;
            sound.pitch = 0.99f;
            sound.volume = 0.8f;
        }
        else
        {
            sound.panStereo = 0;
            sound.pitch = 0.98f;
            sound.volume = 0.7f;
        }
    }

    public void turnLeftOn()
    {
        leftOn = true;
    }

    public void turnLeftOff()
    {
        leftOn = false;
    }

    public void turnRightOn()
    {
        rightOn = true;
    }

    public void turnRightOff()
    {
        rightOn = false;
    }

    IEnumerator ShowTime()
    {
        yield return new WaitForSeconds(3.7f);
        sound.Play();
    }
}
