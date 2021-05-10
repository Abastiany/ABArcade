using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ArcadePlayerController : MonoBehaviour
{
    //private variables
    private float speed = 10.0f;
    private float sideSpeed = 6;
    private float horizontalInput;
    private float forwardInput;

    private Rigidbody playerRb;

    public GameObject msgPanel;

    public PlayTunnelRunnerScript tunnelGameScript;

    public PlayShootingGalleryScript galleryGameScript;

    public ArcadeDoorScript exitDoor;

    public Text popUpMessage;

    public float mouseSensitivity = 100f;
    public GameObject fpsCamera;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        // Get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Move the player side to side
        transform.Translate(Vector3.right * Time.deltaTime * sideSpeed * horizontalInput);

        if (tunnelGameScript.msgPanelActive)
        {
            // play the Tunnel Runner game
            if (Input.GetKeyDown(KeyCode.F))
            {
                //unhide and unlock cursor from center of the screen
                Cursor.lockState = CursorLockMode.None;

                //confine the cursor to the limits of the screen
                Cursor.lockState = CursorLockMode.Confined;

                //load Tunnel Runner Scene
                SceneManager.LoadScene(sceneBuildIndex: 1);
            }
        }

        if (galleryGameScript.msgPanelActive)
        {
            // play the Tunnel Runner game
            if (Input.GetKeyDown(KeyCode.F))
            {
                //load Shooting Gallery Scene
                SceneManager.LoadScene(sceneBuildIndex: 3);
            }
        }

        if (exitDoor.exitPanelActive && exitDoor.msgPanelActive)
        {
            // Quit the game
            if (Input.GetKeyDown(KeyCode.F))
            {
                //close the application
                Debug.Log("QuitGame");
                Application.Quit();
            }
        }
    }
}
