using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArcadeDoorScript : MonoBehaviour
{
    //variables
    public GameObject msgPanel;
    public Text popUpMessage;
    public GameObject exitMsgPanel;

    public bool msgPanelActive = false;
    public bool exitPanelActive = false;

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
        exitMsgPanel.SetActive(true);
        popUpMessage.text = "- Press F to Leave -";
        msgPanelActive = true;
        exitPanelActive = true;
    }

    public void CloseMessagePanel()
    {
        msgPanel.SetActive(false);
        exitMsgPanel.SetActive(false);
        msgPanelActive = false;
        exitPanelActive = false;
    }
}
