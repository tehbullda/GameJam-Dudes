using UnityEngine;
using System.Collections;

public class WaveMovement : MonoBehaviour
{
    private float RepositionTimer = 3.0f;
    public float MovementSpeed = 1.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.eState == Globals.GameState.OVERWORLD)
        {
            Vector3 newPos = transform.position;
            newPos.x += 1.0f * MovementSpeed * Time.deltaTime;
            newPos.y -= 1.0f * MovementSpeed * Time.deltaTime;
            transform.position = newPos;

            RepositionTimer -= Time.deltaTime;
            if (RepositionTimer <= 0.0f)
            {
                RepositionTimer = 3.0f;
                Reposition();
            }
        }
    }

    void Reposition()
    {
        Vector3 newPos;
        newPos.x = Random.Range(Camera.main.transform.position.x - 7.0f, Camera.main.transform.position.x + 3.0f);
        newPos.y = Random.Range(Camera.main.transform.position.y - 3.0f, Camera.main.transform.position.y + 7.0f);
        newPos.z = -3.5f;
        transform.position = newPos;
    }
}
