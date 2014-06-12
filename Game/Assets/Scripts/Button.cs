using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
    public enum TextOrTexture
    {
        Text,
        Texture
    };
    public TextOrTexture choice;

    public string Text;
    public Texture Texture;

    public Rect Rectangle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
        if (choice == TextOrTexture.Text) {
            if (GUI.Button(Rectangle, Text)) {
                Application.LoadLevel(1);
            }
        }
	}
}
