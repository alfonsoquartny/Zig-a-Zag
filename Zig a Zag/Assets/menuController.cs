using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class menuController : MonoBehaviour
{
    public int score;
    public TMP_Text text;
    public GameObject canvas;
    public GameObject player;
    public Vector3 vector3;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        var pos = player.transform.position.z;
        vector3.z = pos;
        vector3.x = player.transform.position.x-13;
        canvas.transform.position = vector3;

        text.text = score+"";
    }
}
