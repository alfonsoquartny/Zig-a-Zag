using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCollisionController : MonoBehaviour
{

    [SerializeField] private groundData groundData;
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            groundData.setGroundRigidbodyValues();
        }
    }
}
