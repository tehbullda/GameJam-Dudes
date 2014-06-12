using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
        if (GUI.Button(new Rect(100, 170, 150, 130), "Start Game"))
            Application.LoadLevel(1);
	}
}
