using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdController : MonoBehaviour
{
    private AudioSource sound;
    private float nextCheer;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        StartCoroutine(ShowTime());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ShowTime()
    {

        yield return new WaitForSeconds(3);
        sound.Play();
        while (true)
        {
            nextCheer = Random.Range(10, 20);
            yield return new WaitForSeconds(nextCheer);
            sound.Play();
        }

    }
}
