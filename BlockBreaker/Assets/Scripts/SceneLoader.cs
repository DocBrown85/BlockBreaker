using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        //EventSystem.current.SetSelectedGameObject(null);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);

        GameSession gameStatus = FindObjectOfType<GameSession>();
        gameStatus.ResetGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
