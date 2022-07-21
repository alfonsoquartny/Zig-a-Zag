using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lefter : MonoBehaviour
{

    public Transform sol;
    public Vector3 increaseValues = new Vector3(0.1f, 0, 0);
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += increaseValues * Time.deltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("solagec"))
        {
            gameObject.transform.position = sol.position;
        }
    }
}
