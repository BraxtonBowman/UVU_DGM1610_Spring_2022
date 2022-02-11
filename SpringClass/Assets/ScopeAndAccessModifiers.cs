using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{

    public int alpha = 5;


    private int beta = 0;
    private int gamma = 5;


    private FruitsAndOffice otherClass;


    void Start()
    {
        alpha = 29;

        otherClass = new FruitsAndOffice();
        otherClass.FruitMachine(alpha, otherClass.apples);
    }


    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }


    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
