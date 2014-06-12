using UnityEngine;
using System.Collections;

public class SelectWeaponTarget : MonoBehaviour {
    public Texture Inactive;
    public Texture Active;
	// Use this for initialization
	void Start () {
        renderer.material.mainTexture = Inactive;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape") && Globals.GamePaused) {
            Globals.GamePaused = false;
        }
        else if (!Globals.GamePaused && renderer.material.mainTexture != Inactive) {
            renderer.material.mainTexture = Inactive;
            Debug.Log("Resetting texture");
        }
	}

    void OnMouseDown() {
        Debug.Log("Aiming Engaged");
        renderer.material.mainTexture = Active;
        Globals.GamePaused = true;
    }
}
