using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatHit : MonoBehaviour
{
   // public GameObject cat;
    public GameObject water;
    public float yIncrease = 1f;
    // Start is called before the first frame update
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            water.transform.position = new Vector3 (water.transform.position.x, water.transform.position.y+yIncrease, water.transform.position.z);

        }
    }
}

