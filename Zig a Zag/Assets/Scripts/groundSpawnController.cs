using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundSpawnController : MonoBehaviour
{

    public GameObject lastGroundObject;


    [SerializeField] private GameObject groundPrefab;

    private GameObject newGroundObject;


    private int groundDirectipon;
    void Start()
    {
        GenerateRandomNewGrounds();
    }

    // Update is called once per frame
public void GenerateRandomNewGrounds()
    {
        for(int i = 0; i < 75; i++)
        {
            CreateNewGround();
        }
    }



    private void CreateNewGround()
    {
        groundDirectipon = Random.Range(0, 2);

        if (groundDirectipon == 0)
        {
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x-1,lastGroundObject.transform.position.y,lastGroundObject.transform.position.z), Quaternion.identity);
            lastGroundObject = newGroundObject;
        }
        else
        {
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x, lastGroundObject.transform.position.y, lastGroundObject.transform.position.z+1), Quaternion.identity);
            lastGroundObject = newGroundObject;
        }
    }
}
