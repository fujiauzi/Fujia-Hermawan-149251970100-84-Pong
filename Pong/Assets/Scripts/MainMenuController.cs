using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Fujia Hermawan - 149251970100-84");
       
    }
    public void OpenAuthor()
    {
        SceneManager.LoadScene("Author");
       Debug.Log("Fujia Hermawan - 149251970100-84");
    }

    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

//comment