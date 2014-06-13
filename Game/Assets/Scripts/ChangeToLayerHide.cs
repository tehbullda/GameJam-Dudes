using UnityEngine;
using System.Collections;

public class ChangeToLayerHide : MonoBehaviour {
    
    public Globals.GameState WhenToShow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (WhenToShow == Globals.eState)
        {
            gameObject.layer = 5;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.layer = 5;
            }
        }
        else {
            gameObject.layer = 8;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.layer = 8;
            }
        }
	}
}
