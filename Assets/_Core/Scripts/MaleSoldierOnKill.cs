using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleSoldierOnKill : MonoBehaviour
{
    ScoreManager scoreManager;
    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void OnKillMaleSoldier()
    {
        scoreManager.GetComponent<ScoreManager>().AddKillScoreMaleSoldier();
    }
}
