using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTransmiter : MonoBehaviour
{

    [SerializeField] private playerController controller;


    public Vector3 GetDirection()
    {
        return controller.Direction;
    }
}
