using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkElfOnKill : MonoBehaviour
{
    ScoreManager scoreManager;
    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }    

    public void OnKillDarkElf()
    {
        scoreManager.GetComponent<ScoreManager>().AddKillScoreDarkElf();
    }
}
