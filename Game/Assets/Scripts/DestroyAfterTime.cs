using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour
{
    public float fDestoryTimer = 1.5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.eState == Globals.GameState.OVERWORLD)
        {
            Destroy(gameObject);
        }
        else
        {
            fDestoryTimer -= Time.deltaTime;
            if (fDestoryTimer <= 0.0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
