﻿using UnityEngine;
using System.Collections;

public class UI_Evasion : MonoBehaviour {
    public int TextSize = 18;
	// Use this for initialization
	void Start () {
        gameObject.guiText.fontSize = TextSize;
	}
	
	// Update is called once per frame
	void Update () {
        if (Globals.eState == Globals.GameState.ENCOUNTER)
        {
            gameObject.guiText.text = "Evasion: " + (Globals.Evasion * 100).ToString();
        }
        else {
            gameObject.guiText.text = "";
        }
	}
}
