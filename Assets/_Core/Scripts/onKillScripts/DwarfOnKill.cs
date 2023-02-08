  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwarfOnKill : MonoBehaviour
{
    ScoreManager scoreManager;
    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void OnKillDwarf()
    {
        scoreManager.GetComponent<ScoreManager>().AddKillScoreDwarf();
    }
}
