using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
   //code from here:https://www.youtube.com/watch?v=BLfNP4Sc_iA 
    
    public int maxHealth = 5;
    public int currentHealth;
    
    public HealthBarScript healthBar;
    // Start is called before the first frame update
    void Start()
    {
       currentHealth = maxHealth;
       healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Q))
        {
            TakeDamage(1);
        }*/

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
        
    }

     /*void OnTriggerEnter2D(Collider2D collision)
    {
        string tagName = gameObject.tag;
        if (tagName == "meteor")
        {
            TakeDamage(1);
            Destroy(gameObject);
        }
    }*/
    void OnCollisionEnter2D (Collision2D coll)
    {
      string tagName = coll.collider.gameObject.tag;
       if (tagName == "meteor")
      {
         TakeDamage(1);
         Destroy(coll.collider.gameObject);
      }
      
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    
}
