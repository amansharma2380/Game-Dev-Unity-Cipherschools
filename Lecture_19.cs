using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoremanager : MonoBehaviour
{
    public static Scoremanager instance;

    private int _score = 0;
    private void awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void Addscore(int point)
    {
        _score += point 
    }
}
