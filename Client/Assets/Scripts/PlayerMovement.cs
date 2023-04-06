using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool AiControlled = true;

    public float playerMovementSpeed = 0.1f;
    public float playerTurningSpeed = 0.05f;

    public float mapSize = 140f;

    public float actualAngle = 0f;

    private void moveBlob(int movementDirection)
    {
        if (movementDirection == 1)
        {
            transform.position += new Vector3(-Mathf.Sin(actualAngle*Mathf.Deg2Rad)*playerMovementSpeed, Mathf.Cos(actualAngle*Mathf.Deg2Rad)*playerMovementSpeed, 0);
        }
        if (movementDirection == -1)
        {
            transform.position += new Vector3(Mathf.Sin(actualAngle*Mathf.Deg2Rad)*playerMovementSpeed, -Mathf.Cos(actualAngle*Mathf.Deg2Rad)*playerMovementSpeed, 0);
        }
        if (movementDirection == 2)
        {
            transform.Rotate(0, 0, playerTurningSpeed);
            if (actualAngle + playerTurningSpeed > 360)
            {
                actualAngle = 0f + playerTurningSpeed;
            } else
            {
                actualAngle += playerTurningSpeed;
            }
        }
        if (movementDirection == -2)
        {
            transform.Rotate(0, 0, -playerTurningSpeed);
            if (actualAngle - playerTurningSpeed < 0)
            {
                actualAngle = 360f - playerTurningSpeed;
            } else
            {
                actualAngle -= playerTurningSpeed;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!AiControlled)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                moveBlob(1);
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveBlob(-1);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                moveBlob(2);
            }
            if (Input.GetKey(KeyCode.D))
            {
                moveBlob(-2);
            }
        } else{

        }

        if (Mathf.Abs(transform.position.x) > mapSize)
        {
            transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
        }
        if (Mathf.Abs(transform.position.y) > mapSize)
        {
            transform.position = new Vector3(transform.position.x, -transform.position.y, transform.position.z);
        }
    }
}
