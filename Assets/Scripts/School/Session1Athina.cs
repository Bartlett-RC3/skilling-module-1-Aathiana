using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Athina : MonoBehaviour
{
    // 1.VARIABLES
    // Scope -- Type -- Name -- Value

    //Numbers
    public int myInteger = 145;
    int largestInteger = int.MaxValue;
    int smallestInteger = int.MinValue;

    double myDouble = 54.3;
    double maxDouble = double.MaxValue;

    float myFloat = 32.455f;

    //search for the generic variables -->IMPRESS OCTAVIAN
    //Recrusive function

    //Text
    string myString = "RC3 best than ever";

    //Logical
    bool myBoolean = true;


    //2.DATA STRUCTURES
    //Scope --Type -- Multiple Values

    //Array --> Order matters
    int[] myIntArray = { 1, 2, 3, 4, 5, 6 };    //I define the values of the array by writing like this
    int[] twentyElementsArray = new int[20];    //Just define that I have an Array of 20 spaces|Allocate that space in memory / If I call sthng that doesn't exist computers returns "null"
    int[,] xyArray = new int[4, 5];             //A grid of 2 arrays

    double[] myDoubleArray = { 10.4, 11.22, 12.33, 45, 80.4 }; //A double Array can also contain integers

    //List -->Flexible(Don't know how many objects I am going to put inside) 
    //I can only add elemetns at the END of the list
    List<int> myList = new List<int>();

    //Dictionary -->A way to organize information - create a set of rules which we can orgnaize something 
    //has a logic  --> we can create our own logic

    Dictionary<string, string> movingAnimals = new Dictionary<string, string>();


    // Use this for initialization
    void Start()
    {
        //Array adding values
        myIntArray[2] = 300;

        //Arrive retrieve value
        Debug.Log(myIntArray[2].ToString());

        //List adding values
        myList.Add(4321);
        myList.Add(42);
        myList.Add(1);

        //List retrive items
        Debug.Log(myList[2].ToString());
        Debug.Log(myList[myList.Count - 1].ToString()); //Debug the last item in the List (always -1 because we start count from 0)

        //Dictionary 
        movingAnimals.Add("flying", "eagle");
        movingAnimals.Add("flying", "parrot");
        movingAnimals.Add("walking", "human");
        movingAnimals.Add("walking", "dog");

        if (movingAnimals.ContainsKey("flying"))
        {
            Debug.Log("A walking animal is" + movingAnimals.Values);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Number adittion function
    //Scope --Type -- Variables -- Body(Instructions)

    float NumberAddtion(float a, float b)       //If you define the type of a function you have to RETURN that type in the function
    {
        //the floats a and b are defined in the parenthesis above
        return a + b;

        /*float additionalResult = a + b;
        return additionalResult;*/

    }

    //Print the daclared variables
    void PrintSomeNumbers()
    {
        Debug.Log(myList[0]);
        Debug.Log(myInteger);
    }

}
