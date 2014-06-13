using UnityEngine;
using System.Collections;

public class Globals : MonoBehaviour {

    public enum GameState
    {
        OVERWORLD,
        ENCOUNTER,
        INVENTORY
    };

    public enum EncounterType
    {
        BOAT,
        ISLAND,
    };

    public static float Accuracy = 0.85f;
    public static float Evasion = 0.30f;
    public static GameObject Target;

    public static bool WeaponTargetingActive = false;
    public static bool GamePaused = false;

    public static int iEnemyShipCounterCurrent = 0;
    public static int iEnemyShipCounterMax = 3;
    public static int iIslandCounterCurrent = 0;
    public static int iIslandCounterMax = 2;

    public static GameState eState = GameState.OVERWORLD;
    public static EncounterType eEncounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Accuracy < 0.0f) {
            Accuracy = 0.0f;
        }
        else if (Accuracy > 1.0f) {
            Accuracy = 1.0f;
        }

        if (Evasion < 0.0f) {
            Evasion = 0.0f;
        }
        else if (Evasion > 1.0f) {
            Evasion = 1.0f;
        }
	
	}
}
