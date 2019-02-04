using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.tag=="bus"){
            Destroy(gameObject);
        }
    }
}
