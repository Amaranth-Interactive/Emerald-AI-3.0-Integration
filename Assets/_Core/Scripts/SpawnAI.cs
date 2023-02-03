using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI.Utility;


public class SpawnAI : MonoBehaviour
{
    public GameObject characterToSpawn;
    public float time = 0.0f;
    public float cooldownDuration = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= cooldownDuration)
        {
            time = 0.0f;
            SpawnAIChar();
        }
    }


    void SpawnAIChar()
    {
        //Spawn our AI using the Emerald Object Pool system
        //Optional on transform position example: + transform.forward * 5
        Vector3 SpawnPosition = transform.position  + (Random.insideUnitSphere * 2);
        SpawnPosition.y = transform.position.y;
        GameObject SpawnedAI = EmeraldAIObjectPool.Spawn(characterToSpawn, SpawnPosition, Quaternion.identity);
    }
}
