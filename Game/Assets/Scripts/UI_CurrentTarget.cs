using UnityEngine;
using System.Collections;

public class UI_CurrentTarget : MonoBehaviour {
    public int fontSize = 18;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Globals.eState == Globals.GameState.ENCOUNTER)
        {
            if (Globals.Target)
            {
                gameObject.guiText.fontSize = fontSize;
                gameObject.guiText.text = Globals.Target.name;
            }
            else
            {
                gameObject.guiText.fontSize = fontSize;
                gameObject.guiText.text = "No target";
            }
        }
        else {
            gameObject.guiText.text = "";
        }
        
	}
}
