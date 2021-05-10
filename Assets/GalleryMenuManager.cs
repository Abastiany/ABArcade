using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GalleryMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //unhide and unlock cursor from center of the screen
        Cursor.lockState = CursorLockMode.None;

        //confine the cursor to the limits of the screen
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Resume()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);
    }

    public void ReturnToArcade()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
