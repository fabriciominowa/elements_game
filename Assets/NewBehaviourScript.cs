using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;
    public string gameSceneName;

    void Start()
    {
        playButton.onClick.AddListener(LoadGameScene);
        quitButton.onClick.AddListener(QuitGame);
    }

    void LoadGameScene()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}