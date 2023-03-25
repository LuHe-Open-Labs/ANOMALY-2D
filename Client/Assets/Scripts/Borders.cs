using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{
    public float mapSize = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x > mapSize/2)
        {
            transform.position = new Vector3(-5f, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -mapSize/2)
        {
            transform.position = new Vector3(5f, transform.position.y, transform.position.z);
        }
        if (transform.position.y > mapSize/2)
        {
            transform.position = new Vector3(transform.position.x, -5f, transform.position.z);
        }
        if (transform.position.y < -mapSize/2)
        {
            transform.position = new Vector3(transform.position.x, 5f, transform.position.z);
        }
    }
}
