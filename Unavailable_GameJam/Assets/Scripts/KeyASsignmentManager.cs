using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeyAssignmentManager : MonoBehaviour
{
    public Button backToOptionMenu;
    // Start is called before the first frame update
    void Start()
    {
        backToOptionMenu.onClick.AddListener(OpenOptions);
    }

    void OpenOptions()
    {
        SceneManager.LoadScene("OptionMenu");
    }
}
