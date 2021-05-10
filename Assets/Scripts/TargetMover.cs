using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    private float targetSpeed = 3.0f;
    private float xMax = 114.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * targetSpeed);

        if (transform.position.x > xMax)
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseTargetSpeed()
    {
        targetSpeed += 2;
    }

    public void ResetTargetSpeed()
    {
        targetSpeed = 3.0f;
    }
}
