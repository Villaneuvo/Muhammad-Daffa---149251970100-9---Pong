using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by Muhammad Daffa 149251970100-9");
    }
    
    public void OpenCredit(){
        SceneManager.LoadScene("Credit");
    }

    public void OpenMenu(){
        SceneManager.LoadScene("Main Menu");
    }
}
