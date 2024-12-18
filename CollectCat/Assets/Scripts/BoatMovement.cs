using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public Transform destinationA;
    public Transform destinationB;
    public float speed = 2f;

    private bool movingAToB = true;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = movingAToB ? destinationB.position : destinationA.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed/10f);

        if(Vector3.Distance(transform.position, targetPosition) < 0.1f)
            movingAToB = !movingAToB;
    }
}
