using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoticeCheck : MonoBehaviour
{
    //code from here: https://www.youtube.com/watch?v=IvHqAzhIDSE

    public GameObject UiObject, txt2, txt3;
    
    void Start() 
    {  
        UiObject.SetActive(false);
        txt2.SetActive(true);
        txt3.SetActive(true);
        
    }
    void Update(){}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Notice")
       {
           UiObject.SetActive(true);   
       }
        if (other.tag == "KeyItem")
       {
           UiObject.SetActive(false);   
       }
       if (other.tag == "metText")
       {
           txt2.SetActive(false);   
       }
       if (other.tag == "showerTxt")
       {
           txt3.SetActive(false);   
       }
    }
    
}
