using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -15 || transform.position.x > 35)
        {
            transform.position = startPos;
        }
        
        if (transform.position.z < -15 || transform.position.z > 15)
        {
            transform.position = startPos;
        }

    }
}
