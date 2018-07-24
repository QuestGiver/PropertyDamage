using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class settings
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

    public void Save()
    {
         var mySettings = new settings()
        {
            qualityValue = (int)quality.value,
            fullScreenBoolean = Screen.fullScreen,
            resString = res.text
        };

        jsonStringSaving = JsonConvert.SerializeObject(mySettings);
        using (StreamWriter sw = File.CreateText("UISettings.json"))
        {
            sw.Write(jsonStringSaving);
        }
       
       
    }

    public void Load()
    {
        jsonStringSaving = File.ReadAllText("UISettings.json");
        settingCarrier = JsonConvert.DeserializeObject<settings>(jsonStringSaving);
        quality.value = settingCarrier.qualityValue;
        Screen.fullScreen = settingCarrier.fullScreenBoolean;
        res.text = settingCarrier.resString;
    }
}
