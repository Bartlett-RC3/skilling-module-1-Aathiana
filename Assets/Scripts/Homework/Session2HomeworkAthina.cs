using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2HomeworkAthina : MonoBehaviour
{
    int countNumbers = 100;
    int number;

    List<int> myEvenList = new List<int>();
    List<int> mySingleList = new List<int>();

    //Create a List and add the instances of the class Dogs
    List<Dogs> myDogs = new List<Dogs>();


    /// <summary>
    ///  i. Write a function that uses a condition
    /// </summary>
    public void CreateListsOfNumbers()
    {
        if (number % 2 == 0)
        {
            myEvenList.Add(number);
            Debug.Log("The number " + number + "is even.");
        }
        else
        {
            mySingleList.Add(number);
            Debug.Log("The number " + number + "is single.");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
      // ii. Write a for Loop 
        for (int number = 0; number < countNumbers; number++)
        {
            CreateListsOfNumbers();
        }

        // Initialize some instances of the class Dogs
        Dogs Max = new Dogs("Max", "Labrador Retriever", "Beige", true, 2, 5.4f);
        Dogs Rex = new Dogs("Rex", "German Sehferd", "Black & Brown", true, 1, 8.2f);
        Dogs Reina = new Dogs("Reina", "Siberian Husky", "White", false, 3, 6.5f);

        // Add the instances of the class to the list: myDogs
        myDogs.Add(Max);
        myDogs.Add(Rex);
        myDogs.Add(Reina);
    }
}

/// <summary>
/// iii. Write a dog class and initialize an instance of the class
/// </summary>
public class Dogs
{
    //Properties of the class Dog
    string name;
    string breed;
    string colour;
    bool gender;
    int age;
    float weight;

    bool isSleeping;
    bool isHungry;
    bool isPlaying;
    float energy = 100;

    /// <summary>
    /// Constructos of the class Dog
    /// </summary>
    /// <param name="_name"></param>
    /// <param name="_breed"></param>
    /// <param name="_colour"></param>
    /// <param name="_gender"></param>
    /// <param name="_age"></param>
    /// <param name="_weight"></param>
    public Dogs(string _name, string _breed, string _colour, bool _gender, int _age, float _weight)
    {
        this.name = _name;
        this.breed = _breed;
        this.colour = _colour;
        this.gender = _gender;
        this.age = _age;
        this.weight = _weight;
    }

    /// <summary>
    /// Functions of the Class Dogg
    /// </summary>
    void Eating()
    {
        bool isHungry = true;
        energy = energy + 2;
    }

    void Playing()
    {
        bool isPlaying = true;
        energy = energy - 5;
    }

    void Sleeping()
    {
        bool isSleeping = true;
        energy = energy + 5;
    }
}
