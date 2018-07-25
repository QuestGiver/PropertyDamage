using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class ScoreSaving : MonoBehaviour
{
    public Timer time;
    private int currentScore;
    private string playerScore;
    private string playerHighScore;
    private int highScore;
    private string path = "Assets/Saves/Score.json"; 
    // Use this for initialization
    void Start()
    {
       // currentScore = ;
        //if(path != null)
        //{
        //    File.ReadAllText(path);
        //    currentScore = JsonConvert.DeserializeObject<int>(playerScore);
            
        //}
        playerScore = JsonConvert.SerializeObject(PublicContainer.Score, Formatting.Indented);
        playerHighScore = JsonConvert.SerializeObject(highScore, Formatting.Indented);
        using (StreamWriter sw = File.CreateText(path))
        {
            sw.Write("Score: " + playerScore + " ");
            sw.Write("High Score: " + playerHighScore);
        }
        if (PublicContainer.Score >= currentScore)
        {

        }
    }
}
