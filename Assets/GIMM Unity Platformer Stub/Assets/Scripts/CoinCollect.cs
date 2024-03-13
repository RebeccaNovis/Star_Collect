using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tagName = gameObject.tag;
        if (tagName == "pick_up")
        {
            ScoreCounter.coinAmount += 1;
            Destroy(gameObject);
        }
        if (tagName == "red")
       {
         ScoreCounter.coinAmount += 3;
         Destroy(gameObject);
       }
       
    }
/*
   void OnCollisionEnter2D (Collision2D coll)
    {
      string tagName = coll.collider.gameObject.tag;
        if (tagName == "pick_up")
        {
            ScoreCounter.coinAmount += 1;
            Destroy(gameObject);
        }
    }
    */
}

