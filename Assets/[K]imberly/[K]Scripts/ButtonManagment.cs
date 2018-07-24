using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManagment : MonoBehaviour
{
    //may add a fade later;
    public void LoadingScene(string index)
    {
        SceneManager.LoadScene(index); //Type name of the scene that is to be loaded
    }

    public void QuitGame()
    {
        Application.Quit(); //Build game for it to work
    }
   
}
