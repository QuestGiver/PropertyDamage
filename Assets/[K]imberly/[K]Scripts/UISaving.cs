using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class settings //gets and sets varibals for the UIjson
{ 
    public int qualityValue { get; set; }
    public bool fullScreenBoolean { get; set; }
    public string resString { get; set; }
}

public class UISaving : MonoBehaviour
{
    [SerializeField]
    private Slider quality;
    [SerializeField]
    private Toggle fullScreen;
    [SerializeField]
    private Text res;
    string jsonStringSaving;
    settings settingCarrier;
    string path = "Assets/Saves/UISettings.json";

    public void Save()
    {
         settings mySettings = new settings() 
        {
            qualityValue = (int)quality.value,
            fullScreenBoolean = Screen.fullScreen,
            resString = res.text
        };

        jsonStringSaving = JsonConvert.SerializeObject(mySettings, Formatting.Indented); //Converts into a json string
        using (StreamWriter sw = File.CreateText(path)) //creats and writes into the file
        {
            sw.Write(jsonStringSaving); //writes to the folder
        }       
    }

    public void Load()
    {
        if (path != null)
        {
            jsonStringSaving = File.ReadAllText(path); //reads the file
            settingCarrier = JsonConvert.DeserializeObject<settings>(jsonStringSaving); //turns it back from a string
            quality.value = settingCarrier.qualityValue; //-----------------|
            Screen.fullScreen = settingCarrier.fullScreenBoolean;//------ Set Values
            res.text = settingCarrier.resString;//--------------------------|
        }
    }
}
