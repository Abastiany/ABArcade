using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject scoreBoard;
    public GameObject Player;
    public Text scoreText;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // pause the game if the player presses P
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(sceneBuildIndex: 2);
        }
    }

    public void increaseScore()
    {
        score++;
        Debug.Log(score);
        scoreText.text = "Score: " + score;
    }
}
