using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 15.0f;
    public GameObject projectilePrefab;

    // variable to make boundary, so someone else can read our code better
    const float hozBoundary = 12.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Hmove = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Hmove * Time.deltaTime * speed);

        // stops player from moving past boundary (right)
        if (transform.position.x > hozBoundary)
        {
            transform.position = new Vector3(hozBoundary, transform.position.y, transform.position.z);
        }
        // stops player from moving past boundary (left)
        if (transform.position.x < -hozBoundary)
        {
            transform.position = new Vector3(-hozBoundary, transform.position.y, transform.position.z);
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
