using UnityEngine;
using System.Collections;

public class ShipOverworldMovement : MonoBehaviour
{
    private Vector3 Destination;
    public float Movespeed = 1.0f;
    static public bool CanMove = true;
    public GameObject Background;

    // Use this for initialization
    void Start()
    {
        EnterOverworld();
    }

    void EnterOverworld()
    {
        Destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.eState == Globals.GameState.OVERWORLD && CanMove)
        {
            if (Vector3.Distance(transform.position, Destination) > 1.0f)
            {
                Vector3 direction = Destination - transform.position;
                direction.Normalize();
                direction.z = 0;
                direction *= Movespeed;
                direction *= Time.deltaTime;

                Vector3 newPos = transform.position;
                newPos.x += direction.x;
                newPos.y += direction.y;
                transform.position = newPos;
                //camera move check
                if (transform.position.y > Camera.main.transform.position.y)
                {
                    Vector3 newCameraPosition = Camera.main.transform.position;
                    newCameraPosition.y = transform.position.y;
                    Camera.main.transform.position = newCameraPosition;
                    if (Background)
                    {
                        Vector3 newBgPos = Background.transform.position;
                        newBgPos.x = newCameraPosition.x;
                        newBgPos.y = newCameraPosition.y;
                        Background.transform.position = newBgPos;
                    }
                }
            }
            if (Input.GetMouseButtonDown(0))
            {
                SetNewDestination();
            }
        }
    }

    void SetNewDestination()
    {
        Destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Destination.z = 0;
        
    }
}
