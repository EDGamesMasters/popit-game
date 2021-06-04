using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
