using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    private float outOfBoundsN = 30.0f;
    private float outOfBoundsS = -15.0f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= outOfBoundsN)
        {
            Destroy(gameObject);
        }
        // else if: is to optimize code
        else if (transform.position.z <= outOfBoundsS)
        {
            Debug.Log("Animal Escaped!");
            Destroy(gameObject);
        }
    }
}
