using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CollectorScript : MonoBehaviour{

    public Text scoreText;
    private int score;

    void IncreasScore () {
        score ++;

        scoreText.text = "Score " + score;
    }
    void OnTriggerEnter2D (Collider2D target) {
        if (target.tag == "Bomb"){

        IncreasScore ();    
        target.gameObject.SetActive (false);

        }


    }



}
