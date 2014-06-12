using UnityEngine;
using System.Collections;

public class MuteMusic : MonoBehaviour {
    private bool muted = false;

    public Texture mutedtexture;
    public Texture unmutedtexture;
	// Use this for initialization
	void Start () {
        renderer.material.mainTexture = unmutedtexture;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        muted = !muted;
        AudioListener.pause = muted;
        if (muted) {
            renderer.material.mainTexture = mutedtexture;
        }
        else {
            renderer.material.mainTexture = unmutedtexture;
        }
    }
}
