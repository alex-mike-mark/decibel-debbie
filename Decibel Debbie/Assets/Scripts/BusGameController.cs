using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BusGameController : MonoBehaviour
{
    public float duration; 
    // How long this level will last for.
    public Text timeDisplay;
    
    private float remainingTime;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        duration = duration - Time.deltaTime;
        timeDisplay.text = ""+(Mathf.Ceil(duration));
        if(duration<0){
            gameOver(true);
        }
    }

    void gameOver(bool victory){
        if ( victory ){
            SceneManager.LoadSceneAsync("Scenes/Music");
        } else {
            // GO TO GAME OVER
        }
    }
}
