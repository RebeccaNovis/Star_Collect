using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code from:https://www.youtube.com/watch?v=_nRzoTzeyxU
[System.Serializable]
public class Dialogue 
{
    public string name;

    [TextArea(2, 10)]
    public string[] sentences;
}
