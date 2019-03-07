using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1HomeworkAthina : MonoBehaviour {

    // i. Declare an int variable and set a value
    int myInt = 5;

    // ii. Declare a float variable and set a value
    float myFloat = 0.5f;

    // iii. Declare a string variable and set a value
    string myString = "Athina";

    // iv. Create a function that prints the declared variables
    void PrintVariables()
    {
        Debug.Log(myInt.ToString());
        Debug.Log(myFloat.ToString());
        Debug.Log(myString);
    }

    // v. Declare and initialize an array
    int[] myArray = new int[20];                                // First way to declare and initialize an array
    float[] myArray2 = { 4.2f, 4.3f, 4.5f, 4.6f, 4.7f, 4.8f };  // Second way to declare and initialize an array

    // vi. Declare and initialize a list
    List<double> myList = new List<double>();

    // vii. Create and initialize a Dictionary
    Dictionary<string, string> myDictionary = new Dictionary<string, string>();


    void Start ()
    {
        // Call the function PrintVariables
        PrintVariables();

        // Define the value in the First[0] & Second[1] place in my Array
        myArray[0] = 1;
        myArray[1] = 2;
        Debug.Log(myArray[0].ToString());

        // Add to doubles variables in my List and Print them
        myList.Add(22.22);
        myList.Add(44.44);
        Debug.Log(myList[0].ToString());

        // Add values in my Dictionary and Print them
        myDictionary.Add("London","Tate Modern");
        myDictionary.Add("London","British Museum");
        myDictionary.Add("Amsterdam", "Rijksmuseum");
        myDictionary.Add("Amsterdam", "Van Gogh Museum");

        // Declare a generic variable --> No need to define the type of each variable
        var genericString = "Athina";
        var genericInt = 2;
        var genericFloat = 0.5f;

        // Print the declared variables
        Debug.Log(genericString);
        Debug.Log(genericInt);
        Debug.Log(genericFloat);
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
