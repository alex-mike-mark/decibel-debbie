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
    public Text gasDisplay;
    public Text fanDisplay;    
    
    private float remainingTime;
    private float remainingGas;
    private float fans;

    void Start()
    {
        remainingGas = 100;
        fans = 0;
    }

    void Update()
    {
        duration = duration - Time.deltaTime;
        remainingGas = remainingGas - Time.deltaTime*2f;
        timeDisplay.text = ""+(Mathf.Ceil(duration));
        gasDisplay.text = ""+(Mathf.Ceil(remainingGas));
        fanDisplay.text = ""+fans;
        
        if(duration<0){
            gameOver(true);
        }
        if(remainingGas<0){
            gameOver(false);
        }
    }

    void gameOver(bool victory){
        if ( victory ){
            SceneManager.LoadSceneAsync("Scenes/Music");
        } else {
            // GO TO GAME OVER
        }
    }

    public void addGas(int units){
        remainingGas = remainingGas + units;
    }

    public void addFan(){
        fans = fans + 1;
    }
}
