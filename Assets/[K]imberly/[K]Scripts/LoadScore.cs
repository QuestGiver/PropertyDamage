using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;

public class LoadScore : MonoBehaviour
{
    private int playerScore;
    public Text highScore;
    public Text score;
    string path = "Assets/Saves/Score";

    // Use this for initialization
    void Start()
    {
        //File.ReadAllText(path);       
    }

    // Update is called once per frame
    void Update()
    {

    }
}
