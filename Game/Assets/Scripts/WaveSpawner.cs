using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public int iWaveLimit = 5;
    private int iWavesExisting = 1;
    private float fSpawnTimer = 0.5f;
    public GameObject WaveObjectType;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (iWavesExisting < iWaveLimit)
        {
            fSpawnTimer -= Time.deltaTime;
            if (fSpawnTimer <= 0.0f)
            {
                fSpawnTimer = 0.5f;
                if (WaveObjectType)
                {
                    Instantiate(WaveObjectType, new Vector3(0, 0, 0), WaveObjectType.transform.rotation);
                    ++iWavesExisting;
                }
            }
        }
    }
}
