using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class newLevel : MonoBehaviour
{
    public KeyItemCollect keyCollect;
    
    void Start()  
    {
      keyCollect = FindObjectOfType<KeyItemCollect>();
    }

    // Update is called once per frame
    void Update(){}
    void OnCollisionEnter2D (Collision2D coll)
    {
     
     string tagName = coll.collider.gameObject.tag;
      if(tagName == "endOfLevelOne")
      {
        SceneManager.LoadScene("Level2"); 
      } 
      if(tagName == "endOfLevelTwo")
      {
        if (keyCollect.isKeyCollected == true) 
        {
            SceneManager.LoadScene("Win");
        }
        else 
        {
            Debug.Log("Get Key");
        }
      } 
    }
}
