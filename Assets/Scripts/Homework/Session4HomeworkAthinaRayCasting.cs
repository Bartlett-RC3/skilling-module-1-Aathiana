using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4HomeworkAthinaRayCasting : MonoBehaviour
{

    //Define my variables
    public GameObject prefabCube;
    private GameObject myCube;

    public int cubeCount = 5;
    public int spaceX = 2;
    public int spaceZ = 2;

    Ray ray;
    RaycastHit hit;


    /// <summary>
    /// Instantiate a random arrange of Cubes
    /// </summary>
    void Start()
    {
        for (int x = 0; x <= cubeCount; x++)
            for (int z = 0; z < cubeCount; z++)
            {
                myCube = Instantiate(prefabCube);
                //Vector3 pos = new Vector3(x*spaceX,1,z* spaceZ);                                          //Grid of Cubes
                Vector3 pos = new Vector3(Random.Range(0, 20), Random.Range(0,20), Random.Range(0,20));   //Random arrange of Cubes
                myCube.transform.localPosition = pos;
            }
    }

    /// <summary>
    /// Create the Raycast hit
    /// </summary>
    private void Update()
    {
        // Ray direction following the mouse
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Ray casting, hit the selected object
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(ray, out hit, 300))
            {
                //Vector3 position = hit.transform.position;
                Destroy(hit.transform.gameObject);
            }

        }
    }
}
