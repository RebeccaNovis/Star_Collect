using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class reStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){}
    void OnCollisionEnter2D (Collision2D coll)
    {
        string tagName = coll.collider.gameObject.tag;
    if (tagName == "reStarter")
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
    }
}
