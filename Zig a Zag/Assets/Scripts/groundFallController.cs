using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundFallController : MonoBehaviour
{

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


  public  IEnumerator SetRigidBodyValues()
    {
        yield return new WaitForSeconds(0.3f);
        rb.isKinematic = false;
        rb.useGravity = true;

    }
}
