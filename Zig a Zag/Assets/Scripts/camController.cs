using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour
{


    [SerializeField] Transform PlayerTransform;


    Vector3 offset;
    Vector3 newPosition;

    [SerializeField] float lerpValue;

    void Start()
    {
        offset = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        SetCameraFollow();
    }


    void SetCameraFollow()
    {
        newPosition = Vector3.Lerp(transform.position, PlayerTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
