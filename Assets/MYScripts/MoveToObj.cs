using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObj : MonoBehaviour
{
    // public Marker marker;
    // The speed the T-Cells are moving towards the marker
    public float speed = 1.0f;

    // The target (virus) position
    //public GameObject target;

    void Update()
    {
        /* WORKS, HAD TO COMMENT BECAUSE OF THE REFERENCE
        if (marker.isPlaced)
        {
            // Move T-Cell a step closer to the virus
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, marker.transform.position, step);
        }
        */

    }
    
}
