using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Athina : MonoBehaviour
{

    public GameObject prefabRefernce;
    IEnumerator createPrefabs;  //I for interface --> ie generic functions

    // Use this for initialization
    void Start()
    {
        //How to instantiate (make) a new prefab? -give object position, rotation and parent

        for (int i = 0; i < 10; i++)
        {
            Vector3 prefabPosition = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
            Quaternion prefabRotation = Quaternion.identity;    //Indentity = (0,0,0)
            GameObject myPrefab = Instantiate(prefabRefernce, prefabPosition, prefabRotation);

            foreach (Transform child in myPrefab.transform)
            {
                child.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 1);
            }

            myPrefab.GetComponent<MeshRenderer>().material.color = new Color(1, 0, 0);
        }
        createPrefabs = DropPrefabsFromHeight();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(createPrefabs);
        Debug.Log(Time.time);
        if (Time.time>5)
        {
            StopCoroutine(createPrefabs);
            StopAllCoroutines();
        }

    }

    //Implement the coroutine
    IEnumerator DropPrefabsFromHeight()     //Create the function of Coroutines
    {
        while (true)
        {
            Vector3 prefbPos = new Vector3(Random.Range(-10, 10), Random.Range(0, 10), Random.Range(-10, 10));
            Quaternion prefabRot = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            Instantiate(prefabRefernce, prefbPos, prefabRot);

            yield return new WaitForSeconds(5); //After 5 seconds it returns, goes out of the Coroutine
        }
    }
}
