using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundData : MonoBehaviour
{
    [SerializeField] private groundFallController groundFallController;



    private void Start()
    {

      
    }

    public void setGroundRigidbodyValues()
    {
        StartCoroutine(groundFallController.SetRigidBodyValues());

    }
}
