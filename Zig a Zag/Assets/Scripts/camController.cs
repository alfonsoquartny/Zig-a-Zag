    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour
{


    [SerializeField] Transform PlayerTransform;
    public GameObject player;
    public bool dead;

    Vector3 offset;
    Vector3 newPosition;

    public GameObject menu;
    public GameObject targetDead;

    [SerializeField] float lerpValue;

    public AudioClip clip;
    public AudioSource asd;
    void Start()
    {
        offset = transform.position - PlayerTransform.position;
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        SetCameraFollow();

        if (dead == true)
        {
            asd.gameObject.SetActive(true);
            lerpValue =0.5f;
            PlayerTransform = targetDead.transform;
            menu.SetActive(true);
        }
    }


    void SetCameraFollow()
    {
        newPosition = Vector3.Lerp(transform.position, PlayerTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }

 
}
