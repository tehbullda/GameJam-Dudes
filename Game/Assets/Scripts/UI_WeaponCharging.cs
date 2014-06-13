using UnityEngine;
using System.Collections;

public class UI_WeaponCharging : MonoBehaviour {
    private int currentCharge = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    public float percentage;
	void Update () {
        if (Globals.eState == Globals.GameState.ENCOUNTER)
        {
            ++currentCharge;
            if (currentCharge >= 100) {
                Globals.EnemyCurrentHP -= 10;
                currentCharge = 0;
            }
            if (gameObject.layer != 5)
            {
                gameObject.layer = 5;
            }
            //Scale from 0 to 0.923
            //Position from -4.77 to 0.04
            percentage = currentCharge / 100.0f;
            float nextpos = 4.81f * percentage;
            nextpos -= 4.77f;
            float nextscale = 0.923f * percentage;
            if (nextscale < 0.0f)
            {
                nextscale = 0.0f;
            }
            if (nextscale > 0.923f)
            {
                nextscale = 0.923f;
            }
            if (nextpos > 0.04f)
            {
                nextpos = 0.04f;
            }
            else if (nextpos < -4.77f)
            {
                nextpos = -4.77f;
            }

            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, nextscale);
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, nextpos);
        }
        else
        {
            if (gameObject.layer != 8)
            {
                gameObject.layer = 8;
            }
        }
	}
}
