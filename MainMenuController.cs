using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   


    public void Play()
        //Unity --> Play Button-->OnCLick()---> Main Menu Controller --> Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Exit()
    //Unity --> Play Button-->OnCLick()---> Main Menu Controller --> Exit()

    {
        Application.Quit();
    }
}
//Na zakonczenie Project Settings --> wrzucamy sceny [ pamietaj o zachowaniu kolejności]