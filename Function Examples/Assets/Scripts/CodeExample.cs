using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeExample : MonoBehaviour
{
    void Awake()
    {
        Say("Hello");
       // int num = Add(2, 5);
       // print(num);

        print(Add(1.0f, 2.0f));
        print(Add(new Vector3(1, 0, 0), new Vector3(0, 1, 0)));
        Color colorA = new Color(0.5f, 1, 0, 1);
        Color colorB = new Color(0.25f, 0.33f, 0, 1);
        print(Add(colorA, colorB));
        print(Add(1));
        print(Add(1, 2));
        print(Add(1, 2, 3));
        print(Add(1, 2, 3, 4));
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
    /*int Add(int numA, int numB)
    {
        int sum = numA + numB;
        return (sum);
    }*/
    float Add(float f0, float f1)
    {
        return (f0 + f1);
    }
    Vector3 Add(Vector3 v0,Vector3 v1)
    {
        return (v0 + v1);
    }
    Color Add(Color c0, Color c1)
    {
        float r, g, b, a;
        r = Mathf.Min(c0.r + c1.r, 1.0f);
        g = Mathf.Min(c0.g + c1.g, 1.0f);
        b = Mathf.Min(c0.b + c1.b, 1.0f);
        a = Mathf.Min(c0.a + c1.a, 1.0f);
        return (new Color(r, g, b, a));
    }
    int Add(params int[] ints)
    {
        int sum = 0;
        foreach(int i in ints)
        {
            sum += i;
        }
        return (sum);
    }


}
