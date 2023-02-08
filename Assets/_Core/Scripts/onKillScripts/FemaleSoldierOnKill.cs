using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemaleSoldierOnKill : MonoBehaviour
{
    ScoreManager scoreManager;
    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void OnKillFemaleSoldier()
    {
        scoreManager.GetComponent<ScoreManager>().AddKillScoreFemaleSoldier();
    }
}
