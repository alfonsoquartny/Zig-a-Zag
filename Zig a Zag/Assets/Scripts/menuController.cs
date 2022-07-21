using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menuController : MonoBehaviour
{
    public int score;
    public int highestScore;
    public TMP_Text text;
    public GameObject canvas;
    public GameObject player;
    public Vector3 vector3;
    public string scenes;
    public TMP_Text highestScoreText;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        highestScore = PlayerPrefs.GetInt("highestScore");

        highestScoreText.text = "Highest Meow: " + highestScore;
        if (score > highestScore)
        {
            PlayerPrefs.SetInt("highestScore", score);
            PlayerPrefs.Save();
        }
        var pos = player.transform.position.z;
        vector3.z = pos;
        vector3.x = player.transform.position.x-13;
        canvas.transform.position = vector3;

        text.text = score+"";
    }





 
}
