using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void LoadTheScene()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitTheGame() { //To Quit From the Game
        Application.Quit();
    }
}
