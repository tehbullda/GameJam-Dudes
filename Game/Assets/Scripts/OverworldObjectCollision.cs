using UnityEngine;
using System.Collections;

public class OverworldObjectCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {

	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Overworld_PlayerShip")
        {
            Globals.eState = Globals.GameState.ENCOUNTER;
            Destroy(gameObject);
        }
    }
}
