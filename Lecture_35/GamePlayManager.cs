using System.Collections;
using System.Collections.Generic;
using UnityEngine;
usnig UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager instance;
    [SerializeField] GameObject targetPrefab;

    int score = 0;
    [SerializeField] Text scoretext;
    private void Awake()
    {
        if(!instance) instance = this;
    }

    private void Start()
    {
        InvokeRepeating("SpawnTarget", 1f, 1f);
    }

    void SpawnTarget()
    {
        float xPos = Random.Range(-7.5f, 7.5f);
        float yPos = Random.Range(-4f, 4f);

        Vector3 randomtargetPos = new Vector3(xPos, yPos, 0);

        Instantiate(targetPrefab, randomtargetPos, Quaternion.identity);
    }

    public void IncrementScore()
    {
        score++;
        scoretext.text = score.ToString();
        Debug.Log("Score : " + score);
    }
}
