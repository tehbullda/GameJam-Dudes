using UnityEngine;
using System.Collections;

public class EncounterSpawner : MonoBehaviour
{
    public float fSpawnTimerReset = 2.0f;
    public float fSpawnTimerCurrent = 2.0f;
    public GameObject EnemyShipObject;
    public GameObject[] aIslandObjectTypes;

    // Use this for initialization
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.eState == Globals.GameState.OVERWORLD && fSpawnTimerCurrent > 0.0f)
        {
            fSpawnTimerCurrent -= Time.deltaTime;
            if (fSpawnTimerCurrent <= 0.0f)
            {
                ResetTimer();
                print("current ships: " + Globals.iEnemyShipCounterCurrent + ". current islands: " + Globals.iIslandCounterCurrent);
                //spawn some shit yo
                if (EnemyShipObject && Globals.iEnemyShipCounterCurrent < Globals.iEnemyShipCounterMax && Random.Range(0, 100) <= 65)
                {
                    GameObject spawningObject;
                    Vector3 spawnPos;
                    spawnPos.x = Random.Range(-6.4f, 6.4f);
                    spawnPos.y = Camera.main.transform.position.y + Random.Range(6.0f, 9.0f);
                    spawnPos.z = -3.871864f;
                    spawningObject = (GameObject)Instantiate(EnemyShipObject.gameObject, spawnPos, EnemyShipObject.transform.rotation);
                    ++Globals.iEnemyShipCounterCurrent;
                    print("spawning ship");
                }
                if (aIslandObjectTypes.Length > 0)
                {
                    int iIslandType = Random.Range(0, aIslandObjectTypes.Length);
                    int iSpawnChance = 100; // 0 - 100
                    if (aIslandObjectTypes[iIslandType] && Globals.iIslandCounterCurrent < Globals.iIslandCounterMax && Random.Range(0, 100) <= iSpawnChance)
                    {
                        GameObject spawningObject;
                        Vector3 spawnPos;
                        spawnPos.x = Random.Range(-5.7f, 5.7f);
                        spawnPos.y = Camera.main.transform.position.y + Random.Range(8.0f, 14.0f);
                        spawnPos.z = -3.871864f;
                        spawningObject = (GameObject)Instantiate(aIslandObjectTypes[iIslandType].gameObject, spawnPos, aIslandObjectTypes[iIslandType].transform.rotation);
                        ++Globals.iIslandCounterCurrent;
                        print("spawning island");
                    }
                }
            }
        }
    }

    void ResetTimer()
    {
        fSpawnTimerCurrent = fSpawnTimerReset;
    }
}
