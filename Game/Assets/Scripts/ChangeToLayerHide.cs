using UnityEngine;
using System.Collections;

public class ChangeToLayerHide : MonoBehaviour
{

    public Globals.GameState WhenToShow;
    public bool IsBoat = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (WhenToShow == Globals.eState && gameObject.layer != 5)
        {
            if (!IsBoat)
            {
                gameObject.layer = 5;
                for (int i = 0; i < transform.childCount; i++)
                {
                    transform.GetChild(i).gameObject.layer = 5;
                }
            }
        }
        else if ((WhenToShow != Globals.eState || (IsBoat && Globals.eEncounter != Globals.EncounterType.BOAT)) && gameObject.layer != 8)
        {
            gameObject.layer = 8;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.layer = 8;
            }
        }
        if (IsBoat && Globals.eEncounter != Globals.EncounterType.BOAT && gameObject.layer != 8)
        {
            gameObject.layer = 8;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.layer = 8;
            }
        }
    }
}
