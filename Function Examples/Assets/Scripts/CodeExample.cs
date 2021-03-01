using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeExample : MonoBehaviour
{
    void Awake()
    {
        Say("Hello");
        int num = Add(2, 5);
        print(num);
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
    int Add(int numA, int numB)
    {
        int sum = numA + numB;
        return (sum);
    }
}
