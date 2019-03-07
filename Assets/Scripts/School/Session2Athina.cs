// Session 2: Conditionals, Loops and Classes 
// UCL RC3 12Nov2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3Students;

public class Session2Athina : MonoBehaviour
{

    int number1 = 10;
    int number2 = 20;
    int number3;

    bool someBool = false;

    string someName = "name";

    string[] tutorNames = { "Dave", "Tyson", "Octavian", "Jordi", "Panos" };

    List<Student> RC2018 = new List<Student>();

    // Use this for initialization
    void Start()
    {
        Debug.Log("A tutor is: " + tutorNames[0]);

        //NAVIGATE DATA
        //For Loop (Variables that counts start, where it ends, what is the increment)
        for (int i=tutorNames.Length-1; i>=0; i--)
        {
            Debug.Log("A tutor is: " + tutorNames[i]);
        }

        for (int counter=0; counter<=number2; counter++)
        {
            Debug.Log("Just testing the counnter");
        }

        //For each loop --> easier to read
        foreach(string tutorName in tutorNames)
        {
            Debug.Log(tutorName);
        }


        //Conditions
        if (number1 < number2)
        {
            //Action if true
            Debug.Log("Number1 is smaller than number 2");
        }
        else
        {
            //Action if false
            Debug.Log("Number2 is smaller than number 1");
        }

        //Question we can ask
        //If somehting is smaller or bigger
        // <, >

        //If something is equal to something else
        // ==

        //Asking multiple questions
        if (number1 < number2 && someBool == true)      //[&&] Both questions must be true to enter if
        {
            //Action
            Debug.Log("Answer to both questions is yes!");
        }

        if (number1 < number2)
        {
            if (someBool == true)
            {
                Debug.Log("Answer to both questions is yes!");
            }
        }

        if (number1 < number2 || someBool == true)  // [||] One part of the question must be true
        {
            Debug.Log("Answer to one of the questions was true");
        }

        //Complex Question by concaternation and by embedding sub quesions
        if ((number1 < number2 && someBool == true) && (someBool == true) && (someBool ==true && someName == "name"))
        {
            Debug.Log("This is too comfusing!Simplify please!");
        }

        //Shorthand if
        number3 = (number1 < number2) ? 100 : 200;  //is the condition true? If true make number3=100, ELSE make 200

    }
    // Update is called once per frame
    void Update()
    {

    }

}






