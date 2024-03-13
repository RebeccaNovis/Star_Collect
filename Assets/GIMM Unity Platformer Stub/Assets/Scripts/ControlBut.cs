using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlBut : MonoBehaviour
{
    public void startLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void startSplashScreen()
    {
        SceneManager.LoadScene("SplashScreen");
    }
    public void startProlouge()
    {
        SceneManager.LoadScene("Prolouge");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
