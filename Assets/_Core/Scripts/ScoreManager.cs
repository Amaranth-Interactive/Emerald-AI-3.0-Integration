using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // caches for displaying score on top right
    public ResourcesScriptableObject rSO;
    public TextMeshProUGUI player1;
    public TextMeshProUGUI player2;
    public TextMeshProUGUI player3;
    public TextMeshProUGUI player4;
    public TextMeshProUGUI player5;
    public TextMeshProUGUI player6;

    // caches for flags
    public GameObject flag1;
    public GameObject flag2;
    public GameObject flag3;
    public GameObject flag4;
    public GameObject flag5;
    public GameObject flag6;
    
    private void Start()
    {
        rSO.femaleFighterScore = 0;
        rSO.maleFighterScore = 0;
        rSO.dwarfScore = 0;
        rSO.rogueScore = 0;
        rSO.darkElfScore = 0;
        rSO.orcScore = 0;
        player1.text = "Dark Elves: " + rSO.darkElfScore; 
        player2.text = "Orcs: " + rSO.orcScore;  
        player3.text = "Dwarves: " + rSO.dwarfScore;
        player4.text = "Paladins: " + rSO.maleFighterScore; 
        player5.text = "Rogues: " + rSO.rogueScore;
        player6.text = "Amazons: " + rSO.femaleFighterScore;         
    }

    public void AddKillScoreDarkElf()
    {
        rSO.darkElfScore += 1;
        player1.text = "Dark Elves: " + rSO.darkElfScore;
        flag1.transform.localScale += new Vector3(0, 0.1f, 0);
    }
    public void AddKillScoreOrc()
    {
        rSO.orcScore += 1;
        player2.text = "Orcs: " + rSO.orcScore;
        flag2.transform.localScale += new Vector3(0, 0.1f, 0);
    }
    public void AddKillScoreDwarf()
    {
        rSO.dwarfScore += 1;
        player3.text = "Dwarves: " + rSO.dwarfScore;
        flag3.transform.localScale += new Vector3(0, 0.1f, 0);
    }
    
    public void AddKillScoreMaleSoldier()
    {
        rSO.maleFighterScore += 1;
        player4.text = "Paladins: " + rSO.maleFighterScore;
        flag4.transform.localScale += new Vector3(0, 0.1f, 0);
    }

    public void AddKillScoreRogue()
    {
        rSO.rogueScore += 1;
        player5.text = "Rogues " + rSO.rogueScore;
        flag5.transform.localScale += new Vector3(0, 0.1f, 0);
    }
    public void AddKillScoreFemaleSoldier()
    {
        rSO.femaleFighterScore += 1;
        player6.text = "Amazons: " + rSO.femaleFighterScore;
        flag6.transform.localScale += new Vector3(0, 0.1f, 0);
    }

}
