using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    public bool IsExiting = false;

    public void ExitGame()
    {
        if(IsExiting == true) {
            Application.Quit();
        }
    }

}
