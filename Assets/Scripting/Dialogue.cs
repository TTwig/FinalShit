using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this before public class is needed to run
[System.Serializable]
public class Dialogue
{
    //name is the name of the NPC we're talking with 
    public string name;

    [TextArea(3, 10)]
    public string[] sentences;
}