using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : MonoBehaviour
{
    private void Start()
    {
    Destroy(GameObject, 2f);
    }

    private void OnMouseDown()
    {
    Debug.Log("HIT");
    GameplayManager.instance.IncrementScore();
    Destroy(GameObject);
    }
}
