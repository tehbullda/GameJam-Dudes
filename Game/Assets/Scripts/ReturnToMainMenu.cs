using UnityEngine;
using System.Collections;

public class ReturnToMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown() {
        Globals.eState = Globals.GameState.OVERWORLD;
        Application.LoadLevel(0);
    }
}
