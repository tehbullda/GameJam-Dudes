using UnityEngine;
using System.Collections;

public class UI_HP_Bar_Enemy : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        renderer.material.color = Color.red;
        Globals.EnemyMaxHP = Globals.EnemyMaxHP + (Globals.EnemyEncounterCounter * 10);
        Globals.EnemyCurrentHP = Globals.EnemyMaxHP + (Globals.EnemyEncounterCounter * 10);
    }

    // Update is called once per frame
    public float percentage = 1;
    void Update()
    {
        if (Globals.eState == Globals.GameState.ENCOUNTER)
        {
            if (Globals.EnemyCurrentHP <= 0) {
                Globals.eState = Globals.GameState.OVERWORLD;
                Globals.EnemyCurrentHP = Globals.EnemyMaxHP;
                Globals.PlayerHP = Globals.PlayerMaxHP;
                Globals.Target = null;
            }
            if (gameObject.layer != 5)
            {
                gameObject.layer = 5;
                Globals.EnemyEncounterCounter++;
            }
            percentage = (float)Globals.EnemyCurrentHP / Globals.EnemyMaxHP;
            float nextpos = 1.9f * percentage; //-4.7(100%) to -6.6(0%)
            nextpos -= 6.6f;
            float nextscale = 0.377f * percentage;
            if (nextscale < 0.0f)
            {
                nextscale = 0.0f;
            }
            if (nextscale > 0.377f)
            {
                nextscale = 0.377f;
            }
            if (nextpos < -6.6f)
            {
                nextpos = -6.6f;
            }
            else if (nextpos > -4.77f)
            {
                nextpos = -4.77f;
            }
            transform.localScale = new Vector3(nextscale, transform.localScale.y, transform.localScale.z);
            transform.localPosition = new Vector3(nextpos, transform.localPosition.y, transform.localPosition.z);
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
