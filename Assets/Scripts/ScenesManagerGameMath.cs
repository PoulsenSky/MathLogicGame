using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManagerGameMath : MonoBehaviour
{

    /*
    public enum Scene {
        MainMenuScene,
        ChooseGrade,
        Credit,
        OptionIfMusicOff,
        OptionTurnMusicOn
    } */

    public void LoadNewGame() {
        SceneManager.LoadScene("ChooseGrade");
    }

    public void LoadMainMenu() {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void LoadCredit() {
        SceneManager.LoadScene("Credit");
    }
}
