using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables
    public Rigidbody playerRb;
    public float strafeSpeed = 20.0f;
    public float horizontalInput;
    private float xRange = 4.1f;   //range value that the player can move side to side along the X axis
    private float yMin = 0.9f;
    private float yMax = 9.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //if the player moves past the predetermined boundaries on the X axis, move the player back to the edge of the boundary
        if (transform.position.x < -xRange)  //left boundary
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.Euler(0, 0, -90);
            //transform.Translate(Vector3.up * horizontalInput * Time.deltaTime * strafeSpeed);
        }

        if (transform.position.x > xRange && transform.position.y < yMin)   //right boundary on bottom
        {
            transform.position = new Vector3(4.5f, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.Euler(0, 0, 90);
            //transform.Translate(Vector3.up * horizontalInput * Time.deltaTime * strafeSpeed);
        }

        if (transform.position.y < yMin && transform.position.x < -xRange)
        {
            transform.position = new Vector3(yMin, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * strafeSpeed);
        }

        if (transform.position.y < yMin && transform.position.x > xRange)
        {
            transform.position = new Vector3(yMin, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * strafeSpeed);
        }

        if (transform.position.y > yMax && transform.position.x > xRange)
        {
            transform.position = new Vector3(yMax, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.Euler(0, 0, 180);
            //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * strafeSpeed);
        }

        if (transform.position.y > yMax && transform.position.x < -xRange)
        {
            transform.position = new Vector3(yMax, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.Euler(0, 0, -180);
            //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * strafeSpeed);
        }

        //detect left and right horizontal input from controller
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * strafeSpeed);  //move the player object along the X axis in the direction input at a predetermined speed based on time and not frames
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Game Over");
    }
}
