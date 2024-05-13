using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Start playing the default game
    public void PlayGame()
    {
        // Get the next level
        //SceneManagement.LoadScence(SceneManagement.getActiveScene().buildIndex + 1);
        Debug.Log("Leaving Main Menu | Entering Play");
    }

    // Close the game
    public void QuitGame()
    {
        Debug.Log("Exiting Application");
        Application.Quit();
    }

    public void openOptions()
    {
        Debug.Log("Leaving Main Menu | Entering Options");
    }

    public void openGameModes()
    {
        Debug.Log("Leaving Main Menu | Entering GameModes");
    }

}
