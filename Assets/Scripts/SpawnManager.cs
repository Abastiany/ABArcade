using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables
    public GameObject[] obstaclePrefabs;

    private float spawnPosZ = 22;      //spawn location on the Z axis
    private float startDelay = 2;
    private float spawnInterval = 4.5f;
    private Vector3 spawnPos;
    private int rotationVariable;

    // Start is called before the first frame update
    void Start()
    {
        //begin spawning animals after a certain amount of time has passed once for every interval of time passed
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Spawn an obstacle at a random location within the tunnel at predetermined intervals
    void SpawnRandomObstacle()
    {
        //local variables
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);           //random value to determine which obstacle is spawned

        switch (obstacleIndex)
        {
            case 0:  //Cube(Regular)
                spawnPos = new Vector3(Random.Range(-3.5f, 3.5f), Random.Range(1.5f, 8.5f), spawnPosZ);
                Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
                break;
            case 1:  //GiantBox
                spawnPos = new Vector3(0, 5, spawnPosZ);
                Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
                break;
            case 2:  //Long
                rotationVariable = Random.Range(0, 1);
                if (rotationVariable == 0)
                {
                    Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
                    spawnPos = new Vector3(0, Random.Range(0.5f, 9.5f), spawnPosZ);
                    Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, spawnRotation);
                }
                else if (rotationVariable == 1)
                {
                    Quaternion spawnRotation = Quaternion.Euler(0, 0, 90);
                    spawnPos = new Vector3(Random.Range(-4.5f, 4.5f), 5, spawnPosZ);
                    Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, spawnRotation);
                }
                break;
            case 3:  //Rectangle
                rotationVariable = Random.Range(0, 1);
                if (rotationVariable == 0)
                {
                    Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
                    spawnPos = new Vector3(Random.Range(-2f, 2f), Random.Range(1f, 9f), spawnPosZ);
                    Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, spawnRotation);
                }
                else if (rotationVariable == 1)
                {
                    Quaternion spawnRotation = Quaternion.Euler(0, 0, 90);
                    spawnPos = new Vector3(Random.Range(-4f, 4f), Random.Range(3f, 7f), spawnPosZ);
                    Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, spawnRotation);
                }
                break;
            case 4:  //Wall(Large)
                rotationVariable = Random.Range(0, 1);
                if (rotationVariable == 0)
                {
                    Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
                    spawnPos = new Vector3(Random.Range(-2.5f, 2.5f), 5, spawnPosZ);
                    Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, spawnRotation);
                }
                else if (rotationVariable == 1)
                {
                    Quaternion spawnRotation = Quaternion.Euler(0, 0, 90);
                    spawnPos = new Vector3(0, Random.Range(2.5f, 7.5f), spawnPosZ);
                    Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, spawnRotation);
                }
                break;
            case 5:  //Wall(Small)
                rotationVariable = Random.Range(0, 1);
                if (rotationVariable == 0)
                {
                    Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
                    spawnPos = new Vector3(Random.Range(-3.5f, 3.5f), Random.Range(2.5f, 7.5f), spawnPosZ);
                    Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, spawnRotation);
                }
                else if (rotationVariable == 1)
                {
                    Quaternion spawnRotation = Quaternion.Euler(0, 0, 90);
                    spawnPos = new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(1.5f, 8.5f), spawnPosZ);
                    Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, spawnRotation);
                }
                break;
            default:
                break;
        }

        //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);   //randomized Vector to determine where on the X axis an animal is spawned

        //spawn predetermined animal at predetermined location
        //Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
    }
}
