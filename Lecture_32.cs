using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] GameObject targetPrefab;

    private void Start()
    {
        SpawnTarget();
    }

    void SpawnTarget()
    {
        Instantiate(targetPrefab);
    }
}
