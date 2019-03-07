using UnityEngine;
//My custom class (object)

public class Humans : MonoBehaviour  //Monobehaviour 
{
    //Properties
    string name = "Octavia";
    int age = 32;
    float height = 170.5f;
    float energy = 100;

    //Behaviours
    void Walking()
    {

    }

   void Sleeping()
    {

    }

    void Eating()
    {

    }

    void WorkingOut()
    {
        energy--;
    }
}
