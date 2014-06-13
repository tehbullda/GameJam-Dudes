using UnityEngine;
using System.Collections;

public class EncounterSpawner : MonoBehaviour
{
    public int iEnemyShipCounter = 0;
    public int iIslandCounter = 0;
    public float fSpawnTimerReset = 10.0f;
    public float fSpawnTimerCurrent = 10.0f;

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
                //spawn some shit yo
            }
        }
    }

    void ResetTimer()
    {
        fSpawnTimerCurrent = fSpawnTimerReset;
    }
}
