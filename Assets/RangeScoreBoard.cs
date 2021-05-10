using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeScoreBoard : MonoBehaviour
{
    public RangeSpawnManager rsm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Target Passed");
        rsm.IncreaseTargetsPassed();
    }
}
