using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueOnKill : MonoBehaviour
{
    ScoreManager scoreManager;
    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void OnKillRogue()
    {
        scoreManager.GetComponent<ScoreManager>().AddKillScoreRogue();
    }
}
