using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class ScoreSaving : MonoBehaviour
{
    public Timer time;
    private string jsonStringSaving; 
    private string path = "Assets/Saves/Score.json"; 
    // Use this for initialization
    void Start()
    {
        jsonStringSaving = JsonConvert.SerializeObject(PublicContainer.Score, Formatting.Indented);
        using (StreamWriter sw = File.CreateText(path))
        {
            sw.Write(jsonStringSaving);
        }
    }
}
