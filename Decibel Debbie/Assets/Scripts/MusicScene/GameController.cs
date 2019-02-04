using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private AudioSource sound;

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
        yield return new WaitForSeconds(3.7f);
        sound.Play();
    }
}
