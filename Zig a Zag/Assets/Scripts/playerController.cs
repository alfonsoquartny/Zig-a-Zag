using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public Vector3 Direction;
    public Vector3 rotationDirection;
    void Start()
    {
        Direction = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        HanleInputs();
    }

    public void HanleInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            changeDirection();
        }

        if (Direction.x == -1)
        {
            rotationDirection.y = 270;
            gameObject.transform.rotation = Quaternion.Euler(rotationDirection);
        }
        if (Direction.x == 0)
        {
            rotationDirection.y = 0;
            gameObject.transform.rotation = Quaternion.Euler(rotationDirection);

        }
    }

  public void changeDirection()
    {
        if (Direction.x == -1)
        {
            Direction = Vector3.forward;
        }
        else
        {
            Direction = Vector3.left;
        }
    }
}
