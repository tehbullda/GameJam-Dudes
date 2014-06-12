using UnityEngine;
using System.Collections;

public class UI_CurrentTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Globals.eState == Globals.GameState.ENCOUNTER)
        {
            if (Globals.Target)
            {
                gameObject.guiText.text = Globals.Target.name;
            }
            else
            {
                gameObject.guiText.text = "No target";
            }
        }
        else {
            gameObject.guiText.text = "";
        }
        
	}
}
