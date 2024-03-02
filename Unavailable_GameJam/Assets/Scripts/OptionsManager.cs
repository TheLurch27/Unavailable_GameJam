using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    [Header("Options Buttons")]
    public Button creditsButton;
    public Button keyAssignmentButton;
    public Button backToMainMenuButton;

    void Start()
    {
        creditsButton.onClick.AddListener(OpenCredits);
        keyAssignmentButton.onClick.AddListener(OpenKeyAssignment);
        backToMainMenuButton.onClick.AddListener(BackToMainMenu);
    }

    void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    void OpenKeyAssignment()
    {
        SceneManager.LoadScene("KeyAssignment");
    }

    void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
