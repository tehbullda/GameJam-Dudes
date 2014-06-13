using UnityEngine;
using System.Collections;

public class ChangeToLayerHide : MonoBehaviour
{

    public Globals.GameState StateWhenShow = Globals.GameState.ENCOUNTER;
    public Globals.EncounterType EncounterWhenShow = Globals.EncounterType.NONE;
    //public bool IsBoat = false;
    public bool ShowWithCrowsNest = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //show IF
        if (StateWhenShow == Globals.eState && EncounterWhenShow == Globals.eEncounter
            || StateWhenShow == Globals.eState && EncounterWhenShow == Globals.EncounterType.NONE)
        {
            //crows nest check
            if ((ShowWithCrowsNest && Globals.bCrowsnestManned) || !ShowWithCrowsNest)
            {
                if (gameObject.layer != 5)
                {
                    gameObject.layer = 5;
                    for (int i = 0; i < transform.childCount; i++)
                    {
                        transform.GetChild(i).gameObject.layer = 5;
                    }
                }
            }
            return;
        }
		
        //don't show IF
        if (StateWhenShow != Globals.eState || (EncounterWhenShow != Globals.eEncounter && EncounterWhenShow != Globals.EncounterType.NONE))
        {
            if (gameObject.layer != 8)
            {
                gameObject.layer = 8;
                for (int i = 0; i < transform.childCount; i++)
                {
                    transform.GetChild(i).gameObject.layer = 8;
                }
            }
        }
    }
}
