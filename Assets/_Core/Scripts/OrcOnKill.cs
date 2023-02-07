using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcOnKill : MonoBehaviour
{
    ScoreManager scoreManager;
    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void OnKillOrc()
    {
        scoreManager.GetComponent<ScoreManager>().AddKillScoreOrc();
    }
}
