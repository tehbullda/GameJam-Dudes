using UnityEngine;
using System.Collections;

public class ChangeLayer : MonoBehaviour {
    public int TargetLayer;

    public Globals.GameState WhenToChange;

    public bool ChangeBackOnOtherStates = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (WhenToChange == Globals.eState)
        {
            gameObject.layer = TargetLayer;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.layer = TargetLayer;
            }
        }
        else {
            gameObject.layer = 5;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.layer = 5;
            }
        }
	}
}
