using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesManager : MonoBehaviour
{
    int childCount = 0;

    [HideInspector] public bool allCoinsCollected = false;
    [SerializedField] private int x;
    private void Start()
    {
        childCount = transform.childCount;
    }

    private void Update()
    {
        if(transform.childCount < childCount)
        {
            Debug.Log("A child object has been destroyed");

            childCount = transfer.childCount;

            if(childCount ==0)
            {
                allCoinsCollected = true;
            }
        }
    }
}
