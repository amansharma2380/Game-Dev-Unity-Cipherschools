using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_ui_Handler : MonoBehaviour
{
    public GameObject instructionPanel;

    public void ToggleInstructionPanel(string toogle)
    {
        if(toogle == "false")
        {
            instructionPanel.SetActive(false);
        }
        else if(toogle == "true")
        {
            instructionPanel.SetActive(true);
        }
    }
}
