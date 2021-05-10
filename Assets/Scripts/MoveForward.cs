using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //variables
    private float speed = 50.0f;
    Rigidbody obstacleRb;

    private float rearBoundary = -30.0f;

    // Start is called before the first frame update
    void Start()
    {
        obstacleRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //move object forward along the Z axis at a certain speed per time instead of frame 
        obstacleRb.AddForce(transform.forward * Time.deltaTime * -speed);
        //transform.Translate(Vector3.back * Time.deltaTime * speed);

        if (transform.position.z < rearBoundary)
        {
            Destroy(gameObject);        //destroy the obstacles as they pass behind the player
        }
    }
}
