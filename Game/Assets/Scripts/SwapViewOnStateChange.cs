using UnityEngine;
using System.Collections;

public class SwapViewOnStateChange : MonoBehaviour
{

    private Globals.GameState eCurrentState = Globals.GameState.OVERWORLD;
    private Vector3 OverworldCameraPos;
    public Vector3 EncounterCameraPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (eCurrentState != Globals.eState)
        {
            if (Globals.eState == Globals.GameState.ENCOUNTER)
            {
                OverworldCameraPos = transform.position;
                transform.position = EncounterCameraPos;
            }
            else if (Globals.eState == Globals.GameState.OVERWORLD)
            {
                transform.position = OverworldCameraPos;
            }
            eCurrentState = Globals.eState;
        }
    }
}
