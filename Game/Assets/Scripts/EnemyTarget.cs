using UnityEngine;
using System.Collections;

public class EnemyTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Globals.Target = gameObject;
        print(gameObject.name + " targeted, buuuuddy.");
    }
}
