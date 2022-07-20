using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundPosController : MonoBehaviour
{
    private groundSpawnController groundspawn;

    private Rigidbody rb;

    [SerializeField] private float endYvaluue;

    private int groundDirection;
    void Start()
    {
        groundspawn = FindObjectOfType<groundSpawnController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        CheckGroundVertical();
    }


    private void CheckGroundVertical()
    {
        if(transform.position.y<=endYvaluue)
        {
            SetRigidbodyValues();
            setgroundNewPos();



        }
    }
    private void setgroundNewPos() 
    {
        groundDirection = Random.Range(0, 2);

        if (groundDirection == 0)
        {
            transform.position = new Vector3(groundspawn.lastGroundObject.transform.position.x - 1f, groundspawn.lastGroundObject.transform.position.y, groundspawn.lastGroundObject.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(groundspawn.lastGroundObject.transform.position.x, groundspawn.lastGroundObject.transform.position.y, groundspawn.lastGroundObject.transform.position.z + 1);

        }


        groundspawn.lastGroundObject = gameObject;
    }
    private void SetRigidbodyValues()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }

}
