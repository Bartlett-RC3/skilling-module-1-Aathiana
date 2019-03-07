using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Athina : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject light;

    public int spacing = 10;
    public int gridX = 10;
    public int gridY = 10;

    // Use this for initialization

    private void Awake() //Executed at the beginning of tha game
    {

    }

    void Start()   //Executed when I press start. I can call this function when I want to restart the game
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(cubePrefab, new Vector3(i * spacing, j * spacing, 0), Quaternion.identity, this.transform); //[This] makes my instantiated cubes children of my initial cube
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //TIME
        Debug.Log("this computer render frame in: " + Time.deltaTime);
        Debug.Log("Since I start palying the game this amount of time has passed: " + Time.timeSinceLevelLoad);
        Debug.Log("Computer has counted this amount of franes: " + Time.frameCount);

        //TRANSLATE
        //Move children gameobjects in x axis

        foreach (Transform child in this.transform)
        {
            //child.Translate(Random.value, 0, 0);
            child.Translate(0, 0, Random.Range(-1f, 1f));
        }

        //ROTATE
        foreach (Transform child in this.transform)
        {
            child.Rotate(0, Random.value, 0);
        }

        /*/ROTATE AROUND
        foreach (Transform child in this.transform)
        {
            child.RotateAround(Vector3.up, Random.value);
        }*/

        //SCALE
        foreach (Transform child in this.transform)
        {
            child.localScale = new Vector3(Random.Range(0.1f, 1), Random.Range(0.1f, 1), Random.Range(0.1f, 1));
        }

        //Record the cubes original Scale
        Vector3[] originalScale = new Vector3[this.transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            originalScale[i] = transform.GetChild(i).localScale;
        }

        //KEAYBORAD INPUT
        if (Input.GetKey(KeyCode.Space)) //Keeping it Pressed
        {
            //If I have pressed space
            //Record the cubes original scale

            foreach (Transform child in this.transform)
            {
                child.localScale = child.localScale * 5f;
            }
        }
        else
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).localScale = originalScale[i];
            }
        }

        //MOUSE BUTTON (0 LEFT -- 1 RIGHT -- 2 MIDDLE)
        if (Input.GetMouseButton(0))
        {
            light.GetComponent<Light>().color = new Color(Random.Range(0,255), Random.Range(0, 255), Random.Range(0, 255)); 
            //Getting components attached to a game object from Unity
            //Color has RGB values
        }

        //STEP BY STEP PROCESS
        //DEPUGGING COPY THE ERROW CODE IN GOOGLE --SOS--
        //STACK Overflow --to find the mistakes

        //It is good to Debug.Log for keep updating the process
    }
}
