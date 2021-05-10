using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RangeSpawnManager : MonoBehaviour
{
    //variables

        //public
    public GameObject target;

    private int score;

    private int hits;

    public int roundNum;

    public TargetMover targetMover;

    public Text scoreText;
    public Text roundText;

        //private
    private int trackToSpawn;

    private int targetsPassed;

    private int spawnPosY = 1;
    private Vector3 spawnPos;
    private float startDelay = 2;
    private float spawnInterval = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        score = 0; // reset score
        roundNum = 1;  // reset round number
        targetsPassed = 0;
        hits = 0;

        roundText.text = "Round: " + roundNum;
        scoreText.text = "Score: " + GetScore().ToString();

        //begin spawning animals after a certain amount of time has passed once for every interval of time passed
        InvokeRepeating("SpawnTarget", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // reduce the spawn interval and increase target speed starting at round 3
        if (roundNum > 2)
        {
            spawnInterval = 3.5f;
            targetMover.IncreaseTargetSpeed();
        }
        // reduce it again at round 6
        if (roundNum > 5)
        {
            spawnInterval = 2.7f;
            targetMover.IncreaseTargetSpeed();
        }

        // pass on to the next round after 10 targets hit
        if (score > 9)
        {
            increaseRound();
        }

        //check for game failure
        if (targetsPassed > (hits + 5))
        {
            Debug.Log("Game Failed");
        }

        //update score board


        score = hits - targetsPassed;
        scoreText.text = "Score: " + GetScore().ToString();

        // pause the game if the player presses P
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(sceneBuildIndex: 4);

            //unhide and unlock cursor from center of the screen
            Cursor.lockState = CursorLockMode.None;

            //confine the cursor to the limits of the screen
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    public int GetScore()
    {
        return score;
    }

    void SpawnTarget()
    {
        trackToSpawn = Random.Range(0, 4);

        switch (trackToSpawn)
        {
            case 0:
                spawnPos = new Vector3(66, spawnPosY, 25);
                Instantiate(target, spawnPos, target.transform.rotation);
                break;
            case 1:
                spawnPos = new Vector3(66, spawnPosY, 30);
                Instantiate(target, spawnPos, target.transform.rotation);
                break;
            case 2:
                spawnPos = new Vector3(66, spawnPosY, 35);
                Instantiate(target, spawnPos, target.transform.rotation);
                break;
            case 3:
                spawnPos = new Vector3(66, spawnPosY, 40);
                Instantiate(target, spawnPos, target.transform.rotation);
                break;
        }
    }

    public void IncreaseScore()
    {
        hits += 1;

        Debug.Log(GetScore());

    }

    private void increaseRound()
    {
        roundNum++;
        hits = 0;
        score = 0;
        targetsPassed = 0;
        roundText.text = "Round: " + roundNum;
    }

    public void IncreaseTargetsPassed()
    {
        targetsPassed++;
    }


}
