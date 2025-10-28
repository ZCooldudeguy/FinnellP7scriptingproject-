using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesandFunctions : MonoBehaviour
{
    //Creating an integer variable
    public int myInt = 6;
    // Start is called before the first frame update
    void Start()
    {
        //running my int variable through the function
        myInt = MultiplyByTwo(myInt);
        //displaying the results on the console
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //creating a function to multiply a value by 2
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
