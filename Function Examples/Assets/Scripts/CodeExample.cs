using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeExample : MonoBehaviour
{
    void Awake()
    {
        Say("Hello");
    }
    void Say(string sayThis)
    {
        print(sayThis);
    }

    public int numTimesCalled = 0; //a
       
    // Update is called once per frame
    void Update()
    {
        numTimesCalled++;  //b
        PrintUpdates();  //c        
    }
    void PrintUpdates()  //d
    {
        string outputMessage = "Updates: " + numTimesCalled;  //e
        print(outputMessage);  //f
    }
}
