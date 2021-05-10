using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayShootingGalleryScript : MonoBehaviour
{

    //variables
    public GameObject msgPanel;
    public Text popUpMessage;

    public bool msgPanelActive = false;

    void OnTriggerEnter(Collider other)
    {
        OpenMessagePanel();
    }

    void OnTriggerExit()
    {
        CloseMessagePanel();
    }

    public void OpenMessagePanel()
    {
        msgPanel.SetActive(true);
        popUpMessage.text = "-Press F to Play -\n- Shooting Gallery -";
        msgPanelActive = true;
    }

    public void CloseMessagePanel()
    {
        msgPanel.SetActive(false);
        msgPanelActive = false;
    }
}