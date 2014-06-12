﻿using UnityEngine;
using System.Collections;

public class UI_Accuracy : MonoBehaviour {
    public int TextSize = 4;
	// Use this for initialization
	void Start () {
        gameObject.guiText.fontSize = TextSize;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.guiText.text = "Accuracy: " + (Globals.Accuracy * 100).ToString();
	}
}
