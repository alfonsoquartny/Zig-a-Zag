using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class menuManager : MonoBehaviour
{
    public int highestScore;
    public TMP_Text highestScoreText;
    void Start()
    {
        highestScore = PlayerPrefs.GetInt("highestScore");
        highestScoreText.text = "Highest Meow: " + highestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void loader(string loaderString)
    {
        SceneManager.LoadScene(loaderString);
        Debug.Log("Oðuzhan");

    }
    public void linkOpener(string link)
    {
        Application.OpenURL(link);
    }
    public void exit()
    {
        Application.Quit();
    }
}
