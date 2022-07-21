using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundFallController : MonoBehaviour
{

    private Rigidbody rb;
    private bool scorePlus;
   public menuController menuCont;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        menuCont = FindObjectOfType<menuController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scorePlus == true)
        {
            menuCont.score = menuCont.score + 1;
            scorePlus = false;
        }
    }


  public  IEnumerator SetRigidBodyValues()
    {
        yield return new WaitForSeconds(0.5f);
        rb.isKinematic = false;
        rb.useGravity = true;
        scorePlus = true;

    }
}
