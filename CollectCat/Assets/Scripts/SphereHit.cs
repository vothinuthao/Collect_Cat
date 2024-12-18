using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = new Color(0.78f, 0.05f, 0.97f);
            gameObject.tag = "PurpleSphere";
        }
    }
}
