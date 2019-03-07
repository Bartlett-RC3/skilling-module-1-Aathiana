using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4HomeworkAthina : MonoBehaviour
{

    //Define my variables
    public GameObject cubePrefab;
    private GameObject myPrefab;

    //Define the Coroutine
    IEnumerator createColorCoroutine;


    /// <summary>
    /// Instantiate my Prefab and Start the Coroutine
    /// </summary>
    void Start()
    {
        myPrefab = Instantiate(cubePrefab);

        createColorCoroutine = ChangeCubeColors();
        StartCoroutine(createColorCoroutine);
    }


    /// <summary>
    /// Debug the Actual time
    /// </summary>
    private void Update()
    {
        Debug.Log(Time.time);
    }


    /// <summary>
    /// Create a Coroutine that the colour of the cube changes every 2 seconds
    /// </summary>
    /// <returns></returns>
    IEnumerator ChangeCubeColors()
    {
        while ( true)
        {
            myPrefab.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
            yield return new WaitForSeconds(2);
        }
    }

}
