using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3HomeworkAthina : MonoBehaviour {

    // Define my GameObject
    public GameObject cubePrefab;
    float spacing = 2f;

    //Create a List of Random Colors
    List<Color> randomColors = new List<Color>();

    /// <summary>
    /// Instantiate a 3d Grid of Cubes in a random range from 5-10
    /// </summary>
    void Start ()
    {
        var cubeCount = Random.Range(5, 10);

        for (int x = 0; x < cubeCount; x++)
        {
            for (int y = 0; y < cubeCount; y++)
            {
                for (int z=0; z<cubeCount; z++)
                {
                    Instantiate(cubePrefab, new Vector3(x * spacing, y * spacing, z * spacing), Quaternion.identity, this.transform);
                }
            }
        }

        //Define a Random range of 30 colors and adding them to a Color List
        for (int i = 0; i < 30; i++)
        {
            randomColors.Add(Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
        }
    }

    /// <summary>
    /// 
    /// </summary>
	void Update ()
    {
        //Move the cubes in a random range from -1 to 1 in axis: X,Y,Z 
        foreach (Transform child in this.transform)
        {
            child.Translate(Random.Range(0, 0), Random.Range(0,0), Random.Range(-1f, 1f));
        }


        //Change the color of the instantiated cubes every time Space is pressed
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //Define a variable of random colors in a Random range form 0 - (Length of the randomColors List)
            var randomColor = randomColors[Random.Range(0, randomColors.Count-1)];

            //Change the color of every child
            foreach (Transform child in this.transform)
            {
                child.GetComponent<Renderer>().material.color = randomColor;
            }
        }
    }
}
