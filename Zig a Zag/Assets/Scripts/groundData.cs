using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundData : MonoBehaviour
{
    [SerializeField] private groundFallController groundFallController;


    public GameObject[] collactables;
 public Transform pos;

    private void Start()
    {

       var collactable = Random.RandomRange(0, 7);

        if (collactable == 0)
        {
            Instantiate(collactables[0],pos.position,Quaternion.identity);
        }
        if (collactable == 1)
        {
            Instantiate(collactables[1], pos.position, Quaternion.identity);
        }
        if (collactable == 2)
        {
            Instantiate(collactables[2], pos.position, Quaternion.identity);
        }
        if (collactable == 3)
        {
            Debug.Log("boþ");
        }
        if (collactable == 4)
        {
            Debug.Log("boþ");
        }

        if (collactable == 5)
        {
            Debug.Log("boþ");
        }
        if (collactable == 6)
        {
            Debug.Log("boþ");
        }
        if (collactable == 7)
        {
            Debug.Log("boþ");
        }
    }

    public void setGroundRigidbodyValues()
    {
        StartCoroutine(groundFallController.SetRigidBodyValues());

    }
}
