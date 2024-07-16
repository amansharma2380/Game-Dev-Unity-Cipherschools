using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Boolean hasGameEnded = false;
     public void Endgame()
    {
        if (hasGameEnded == false)
        {
            hasGameEnded = true;
            Invoke("Restart", 1f);

        }
    }

    void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
