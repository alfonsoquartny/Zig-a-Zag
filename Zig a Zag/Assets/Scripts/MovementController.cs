using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private DataTransmiter datatranmister;

    [SerializeField] private float moveSpeed;


    private void Update()
    {
        setMovement();
    }


    void setMovement()
    {
        transform.position += datatranmister.GetDirection()*moveSpeed*Time.deltaTime;
    }
}
