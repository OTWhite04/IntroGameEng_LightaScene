using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Owen_Hospital_Level");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Story_Menu");
    }
   
    public void QuitGame()
    {
        Application.Quit();
    }

}
