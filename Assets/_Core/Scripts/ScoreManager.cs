using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public ResourcesScriptableObject rSO;
    public TextMeshProUGUI player1;
    public TextMeshProUGUI player2;
    public TextMeshProUGUI player3;
    public TextMeshProUGUI player4;
    public TextMeshProUGUI player5;
    public TextMeshProUGUI player6;

    private void Start()
    {
        rSO.femaleFighterScore = 0;
        rSO.maleFighterScore = 0;
        rSO.dwarfScore = 0;
        rSO.rogueScore = 0;
        rSO.darkElfScore = 0;
        rSO.orcScore = 0;
        player1.text = "Player 1: " + rSO.femaleFighterScore;
        player2.text = "Player 2: " + rSO.maleFighterScore;
        player3.text = "Player 3: " + rSO.dwarfScore;
        player4.text = "Player 4: " + rSO.rogueScore;
        player5.text = "Player 5: " + rSO.darkElfScore;
        player6.text = "Player 6: " + rSO.orcScore;        
    }

    public void AddKillScoreFemaleSoldier()
    {
        rSO.femaleFighterScore += 1;
        player1.text = "Player 1: " + rSO.femaleFighterScore;
    }

    public void AddKillScoreMaleSoldier()
    {
        rSO.maleFighterScore += 1;
        player2.text = "Player 2: " + rSO.maleFighterScore;
    }

    public void AddKillScoreDwarf()
    {
        rSO.dwarfScore += 1;
        player3.text = "Player 3: " + rSO.dwarfScore;
    }

    public void AddKillScoreRogue()
    {
        rSO.rogueScore += 1;
        player4.text = "Player 4: " + rSO.rogueScore;
    }

    public void AddKillScoreDarkElf()
    {
        rSO.darkElfScore += 1;
        player5.text = "Player 5: " + rSO.darkElfScore;
    }

    public void AddKillScoreOrc()
    {
        rSO.orcScore += 1;
        player6.text = "Player 6: " + rSO.orcScore;
    }
}
