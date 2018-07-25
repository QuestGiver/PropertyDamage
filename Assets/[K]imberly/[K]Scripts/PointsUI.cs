using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsUI : MonoBehaviour
{
    public static PointsUI instance;
    [SerializeField]
    private Text pointsUI;


    private void Start()
    {
        PointsUI.instance = this;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateUI(int updateUI)
    {
        pointsUI.text = "Objects Destroyed\n" + updateUI;
    }
}
