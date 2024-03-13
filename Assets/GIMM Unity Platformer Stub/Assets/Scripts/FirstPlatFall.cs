using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlatFall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  void OnCollisionExit2D (Collision2D coll) 
  {
   if (coll.transform.name=="Player")
   {
     Destroy (gameObject);
   }  //destroy immediately,use Destroy (gameObject,3); for destroy after 3 sec.
   //found from: https://answers.unity.com/questions/245826/script-for-vanishing-platforms.html
  }
}
