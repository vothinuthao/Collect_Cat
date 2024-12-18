using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour

{
    public GameObject spherePrefab;
    public int sphereCount = 5;
    public float spawnRadius = 2f;
    public float minHeight = 0f;
    public float maxHeight = 1f;


    void Start()
    {
        SpawnSpheres();
    }

    // Update is called once per frame
    private void SpawnSpheres()
    {
        for (int i = 0; i < sphereCount; i++) 
        {
            //Vector3 randomPosition = Random.insideUnitSphere * spawnRadius;
            //randomPosition.y = Random.Range(minHeight, maxHeight);
            //Instantiate(spherePrefab, randomPosition, Quaternion.identity);
            var obj = SpawnGameObject(transform, spherePrefab);
            obj.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
         

        }

    }

    public GameObject SpawnGameObject(Transform parent, GameObject prefab)
    {
        GameObject go = Instantiate(prefab, Vector3.zero, Quaternion.identity);
        go.transform.SetParent(parent);
        go.transform.localPosition = Vector3.zero;
        go.transform.localRotation = Quaternion.identity;
        go.transform.localScale = Vector3.one;
        return go;
    }

}
