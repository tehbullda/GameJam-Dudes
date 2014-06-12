using UnityEngine;
using System.Collections;

public class ShipOverworldMovement : MonoBehaviour
{

    public Vector3 Destination;
    public float Movespeed = 1.0f;

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
    void Update() {
	    if(Vector3.Distance(transform.position, Destination) > 20.0f)
        {
            Vector3 direction = Destination - transform.position;
            direction.Normalize();
            direction *= Movespeed;
            direction *= Time.deltaTime;

            Vector3 newPos = transform.position;
            newPos.x += direction.x;
            newPos.y += direction.y;
            transform.position = newPos;
            Debug.Log(transform.position);
        }
        if(Input.GetMouseButtonDown(0))
        {
            SetNewDestination();
        }
	}

    void SetNewDestination()
    {
        //Destination = Input.mousePosition;
        Destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
