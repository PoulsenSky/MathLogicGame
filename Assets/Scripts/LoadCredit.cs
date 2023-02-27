using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCredit : MonoBehaviour
{
    public void OnClickCredit()
    {
        SceneManager.LoadScene(2);  //0 = Main Menu, //1 = ChooseGrade
    }

}
