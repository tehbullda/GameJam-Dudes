using UnityEngine;
using System.Collections;

public class OverWorldIslandCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Overworld_PlayerShip")
        {
            Globals.eState = Globals.GameState.ENCOUNTER;
            Globals.eEncounter = Globals.EncounterType.ISLAND;
            Globals.eIslandType = (Globals.IslandType)Random.Range(0, (int)Globals.IslandType.SIZE);
            Debug.Log(Globals.eIslandType.ToString());
            Destroy(gameObject);
        }
    }
}
