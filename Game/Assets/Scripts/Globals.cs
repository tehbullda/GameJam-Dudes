using UnityEngine;
using System.Collections;

public class Globals : MonoBehaviour
{

    public enum GameState
    {
        OVERWORLD,
        ENCOUNTER,
        INVENTORY,
        GAMEOVER
    };

    public enum EncounterType
    {
        BOAT,
        ISLAND,
    };
    public enum IslandType
    {
        CHEST,
        BANDIT,
        NATIVES,
        STRANDED,
        SIZE
    };

    public static float Accuracy = 0.85f;
    public static float Evasion = 0.30f;
    public static int PlayerHP = 100;
    public static int PlayerMaxHP = 100;

    public static int EnemyEncounterCounter = 0;
    public static int EnemyMaxHP = 50;
    public static int EnemyCurrentHP = 50;

    public static GameObject Target;

    public static bool WeaponTargetingActive = false;
    public static bool GamePaused = false;

    public static int iEnemyShipCounterCurrent = 0;
    public static int iEnemyShipCounterMax = 3;
    public static int iIslandCounterCurrent = 0;
    public static int iIslandCounterMax = 2;

    public static bool bCrowsnestManned = false;

    public static GameState eState = GameState.OVERWORLD;
    public static EncounterType eEncounter;
    public static IslandType eIslandType;

    // Use this for initialization
    void Awake()
    {
        eState = GameState.OVERWORLD;
        Accuracy = 0.85f;
        Evasion = 0.30f;
        PlayerHP = 100;
        PlayerMaxHP = 100;

        EnemyEncounterCounter = 0;
        EnemyMaxHP = 50;
        EnemyCurrentHP = 50;

        Target = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Accuracy < 0.0f)
        {
            Accuracy = 0.0f;
        }
        else if (Accuracy > 1.0f)
        {
            Accuracy = 1.0f;
        }

        if (Evasion < 0.0f)
        {
            Evasion = 0.0f;
        }
        else if (Evasion > 1.0f)
        {
            Evasion = 1.0f;
        }

    }
}
