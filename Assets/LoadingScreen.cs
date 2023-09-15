using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public string gameScene;
    public float loadingTime = 20.0f;
    public AudioClip musicClip;

    private AudioSource audioSource;

    void Start()
    {
        StartCoroutine(LoadGameScene());
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musicClip;
        audioSource.Play();
    }

    IEnumerator LoadGameScene()
    {
        yield return new WaitForSeconds(loadingTime);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(gameScene);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}