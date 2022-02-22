using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string name = "John";
        Console.WriteLine(name);

        int myNum;
        myNum = 15;
        myNum = 20; //myNum is now 20
        Console.WriteLine(myNum);

        int myNum = 5; // Integer number
        double myDoubleNum = 5.99D; // Float number
        char myLetter = 'D'; // Character
        bool myBool = true; // Boolean
        string myText = "Hello";

        int myNum = 100000;
        Console.WriteLine(myNum);

        int myNum = 15000000000L;
        Console.WriteLine(myNum);

        float aNum = 5.75F;
        Console.WriteLine(myNumb);

        double myNum = 19.99D;
        Console.WriteLine(myNum);

        float f1 = 35e3F;
        double d1 = 12E4D;
        Console.WriteLine(f1);
        Console.WriteLine(d1);

    }

    // Update is called once per frame
    void Update()
    {

    }
}