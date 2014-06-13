using UnityEngine;
using System.Collections;

public class SwapViewOnStateChange : MonoBehaviour
{

    private Globals.GameState eCurrentState = Globals.GameState.OVERWORLD;
    private Vector3 OverworldCameraPos;
    public Vector3 EncounterCameraPos;
    public Vector3 GameOverCameraPos;

    void Awake()
    {
        transform.position = new Vector3(0,0,-13.4f);
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
            else if (Globals.eState == Globals.GameState.GAMEOVER)
            {
                transform.position = GameOverCameraPos;
            }
            eCurrentState = Globals.eState;
        }
    }
}
