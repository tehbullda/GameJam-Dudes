﻿using UnityEngine;
using System.Collections;

public class EnemyTarget : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (Globals.WeaponTargetingActive)
        {
            Globals.Target = gameObject;
            Globals.WeaponTargetingActive = false;
            Globals.GamePaused = false;
        }
    }
}
