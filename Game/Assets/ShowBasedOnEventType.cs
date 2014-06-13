using UnityEngine;
using System.Collections;

public class ShowBasedOnEventType : MonoBehaviour
{
    public Globals.EncounterType TypeToShow;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.eEncounter == TypeToShow && gameObject.layer != 1)
        {
            gameObject.layer = 1;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.layer = 1;
            }
        }
        else if (Globals.eEncounter != TypeToShow && gameObject.layer != 8)
        {
            gameObject.layer = 8;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.layer = 8;
            }
        }
    }
}
