using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    // my class members
    void killIt()
    {
        GetComponent<Rigidbody2D>().isKinematic=false;
        Destroy(gameObject,0.5f);
    }

    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody2D>().isKinematic=true; 
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag=="Player")
        {
            Invoke("killIt",2);
            //waits 2 sec then destroys platform
        }
        /*if (collision.gameObject.tag == "theobjectToIgnore")
        {
            Physics.IgnoreCollision(theobjectToIgnore.GetComponent<Collider>(), GetComponent<Collider>());
        }
        */
    }
   
}
