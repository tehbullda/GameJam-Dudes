using UnityEngine;
using System.Collections;

public class UI_HP_Bar_Player : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        renderer.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.eState == Globals.GameState.ENCOUNTER)
        {
            if (Globals.PlayerHP <= 0) {
                Globals.eState = Globals.GameState.GAMEOVER;
                Globals.PlayerHP = Globals.PlayerMaxHP;
            }
            if (gameObject.layer != 5)
            {
                gameObject.layer = 5;
            }
            float percentage = Globals.PlayerHP / 100.0f;
            float nextpos = 1.82f * percentage; //1.6 to 3.42
            nextpos += 1.6f;
            float nextscale = 0.377f * percentage;
            if (nextscale < 0.0f)
            {
                nextscale = 0.0f;
            }
            else if (nextscale > 0.377f)
            {
                nextscale = 0.377f;
            }
            if (nextpos < 1.6f)
            {
                nextpos = 1.6f;
            }
            else if (nextpos > 3.42f)
            {
                nextpos = 3.42f;
            }
            transform.localScale = new Vector3(nextscale, transform.localScale.y, transform.localScale.z);
            transform.localPosition = new Vector3(nextpos, transform.localPosition.y, transform.localPosition.z);
        }
        else {
            if (gameObject.layer != 8)
            {
                gameObject.layer = 8;
            }
        }
    }
}
