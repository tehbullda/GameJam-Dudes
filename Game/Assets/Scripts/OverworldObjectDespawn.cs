using UnityEngine;
using System.Collections;

public class OverworldObjectDespawn : MonoBehaviour
{

    public float fDespawnCheckTimerReset = 12.0f;
    public float fDespawnCheckTimerCurrent = 12.0f;

    // Use this for initialization
    void Start()
    {
        ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {

        if (Globals.eState == Globals.GameState.OVERWORLD && fDespawnCheckTimerCurrent > 0.0f)
        {
            fDespawnCheckTimerCurrent -= Time.deltaTime;
            if (fDespawnCheckTimerCurrent <= 0.0f)
            {
                ResetTimer();
                if (Vector3.Distance(Camera.main.transform.position, transform.position) > 20.0f)
                {

                    if (tag == "EnemyShip")
                    {
                        --Globals.iEnemyShipCounterCurrent;
                        print("destroying " + gameObject.name);
                    }
                    else if (tag == "Island")
                    {
                        --Globals.iIslandCounterCurrent;
                        print("destroying " + gameObject.name);
                    }
                    Destroy(gameObject);
                }
            }
        }
    }
    void ResetTimer()
    {
        fDespawnCheckTimerCurrent = fDespawnCheckTimerReset;
    }
}
