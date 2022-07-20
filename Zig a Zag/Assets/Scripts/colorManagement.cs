using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorManagement : MonoBehaviour
{
    [SerializeField] Material groundMat;

    [SerializeField] Color[] colors;

    int colorIndex = 0;

    [SerializeField] float lerpValue;
 [SerializeField] private  float time;
 private   float currentTime;


    private void Update()
    {
        SetColorTime();
        SetSmooth();
    }



    private void SetColorTime()
    {
        if (currentTime <= 0)
        {
            checkColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }


   private void checkColorIndexValue()
    {
        colorIndex++;
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }


   private void SetSmooth()
    {
        groundMat.color = Color.Lerp(groundMat.color, colors[colorIndex], lerpValue * Time.deltaTime);
    }


    private void OnDestroy()
    {
        groundMat.color = colors[0];
    }
}
