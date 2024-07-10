using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ScoreManagement;

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

    public void ChangeCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        int nextIndex = currentScene.buildIndex + 1;

        SceneManager.LoadScene(nextIndex);
    }
}
