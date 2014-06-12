using UnityEngine;
using System.Collections;

public class CloudMovement : MonoBehaviour
{
    public float fMoveSpeed = 1.0f;

    // Use this for initialization
    void Start()
    {
        Vector3 outsideScreenPos = transform.position;
        outsideScreenPos.y = Random.Range(0.8f, 4.0f);
        transform.position = outsideScreenPos;
    }

    // Update is called once per frame
    void Update() {

        Vector3 newPos = transform.position;
        newPos.x -= Time.deltaTime * fMoveSpeed;
        transform.position = newPos;

        if (transform.position.x < -8.0f)
        {
            Vector3 outsideScreenPos = transform.position;
            outsideScreenPos.x = 8.0f;
            outsideScreenPos.y = Random.Range(0.8f, 4.0f);
            transform.position = outsideScreenPos;
            Debug.Log(outsideScreenPos);
        }
	}
}
