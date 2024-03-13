using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeyItemCollect : MonoBehaviour
{
    public bool isKeyCollected = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tagName = gameObject.tag;
       
        if (tagName == "KeyItem")
        {
            isKeyCollected = true;
            Destroy(gameObject);
            Debug.Log(isKeyCollected);
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

