using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayTunnelRunnerScript : MonoBehaviour
{

    //variables
    public GameObject msgPanel;
    public Text popUpMessage;

    public bool msgPanelActive = false;

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
        OpenMessagePanel();
    }

    void OnTriggerExit()
    {
        CloseMessagePanel();
    }

    public void OpenMessagePanel()
    {
        msgPanel.SetActive(true);
        popUpMessage.text = "-Press F to Play -\n- Tunnel Runner -";
        msgPanelActive = true;
    }

    public void CloseMessagePanel()
    {
        msgPanel.SetActive(false);
        msgPanelActive = false;
    }
}
