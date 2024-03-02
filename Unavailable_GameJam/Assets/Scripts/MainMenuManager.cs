using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [Header("MainMenu Buttons")]
    public Button startGameButton;
    public Button exitGameButton;
    public Button optionsButton;

    void Start()
    {
        startGameButton.onClick.AddListener(StartGame);
        exitGameButton.onClick.AddListener(ExitGame);
        optionsButton.onClick.AddListener(OpenOptions);
    }

    void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    void ExitGame()
    {
        Application.Quit();
    }

    void OpenOptions()
    {
        SceneManager.LoadScene("OptionMenu");
    }

    void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
