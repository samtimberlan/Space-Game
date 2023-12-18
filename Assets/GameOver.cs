using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class GameOver : MonoBehaviour
{
    public TMP_Text PointsString = null;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        PointsString.text = score.ToString() + "Points";
    }

    public void Restart(){
        SceneManager.LoadScene("SpaceShooterScene");
    }

    public void Exit(){
        
    }
}
