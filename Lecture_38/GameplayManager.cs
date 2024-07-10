using System.Collections;
using System.Collections.Generic;
using UnityEngine;
usnig UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager instance;
    [SerializeField] GameObject targetPrefab;
    [SerializeField] GameObject winPanel;

    int score = 0;
    bool hasWon = false;
    [SerializeField] Text scoretext;
    private void Awake()
    {
        if(!instance) instance = this;
    }

    private void Start()
    {
        winPanel.SetActive(false);
        //InvokeRepeating("SpawnTarget", 1f, 1f);
    }

    public void StartSpawingTargets()
    {
        InvokeRepeating("SpawnTarget", 1f, 1f);
    }

    private void Update()
    {
        if(hasWon) CancelInvoke("SpawnTarget");
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

        if(score >= 10)
        {
            winPanel.SetActive(true);
            hasWon = true;
        }
        Debug.Log("Score : " + score);
    }
}
