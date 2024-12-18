using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHIt : MonoBehaviour
{
   MeshCollider waterMeshCollider;
    
   private void OnCollisionEnter(Collision colli)
    {
        if (colli.gameObject.tag == "Player")
        {
            waterMeshCollider = GetComponent<MeshCollider>();
            waterMeshCollider.enabled = false;
        }

    }
}
