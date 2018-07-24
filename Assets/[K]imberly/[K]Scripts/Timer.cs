using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public ScoreSaving saving;

    public float timer; //Set how long the player has

    public Text timerText; //Drag the timer into the box

    private void Start()
    {
        StartCoroutine(CountDown(timer)); //Starts the count down
        saving.enabled = false;
    }

    IEnumerator CountDown(float timer)
    {
        for (float i = timer - 1; i > 0; i--)
        {
            timerText.text = string.Format("{0:D2}:{1:D2}", (int)(i / 60 % 60), (int)(i % 60)); //Updates the UI while also doing the math for the Microwave timer
            yield return new WaitForSeconds(1);
            if (i == 0) //Checks if the timer is at one and makes the text appear as a zero
            {
                //timerText.text = string.Format("{0:D2}:{1:D2}", "00", "00");
                saving.enabled = true;
                SceneManager.LoadScene("EndScreen");
            }
        }
    }
}
