using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("START_MENU");
    }
    public static void LoadGame()
    {
        SceneManager.LoadScene("Game_Scene");
    }
    public static void LoadInstructions()
    {
        SceneManager.LoadScene("INSTRUCTIONS");
    }
    public static void QuitGame()
    {
        Application.Quit();
    }
}
