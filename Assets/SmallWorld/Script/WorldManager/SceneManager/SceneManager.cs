using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    public String nextLevel;
    public bool levelLoaded;

    private AsyncOperation async;
    public float progress;

    public string defaultLevel = "LevelSelect";

    // Use this for initialization
    void Start()
    {
        UnityEngine.SceneManagement.SceneManager.sceneLoaded += (scene, sceneMode) =>
        {
            //var activeScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            Debug.Log("Load Scene: " + scene.name);
            UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene);
        };
        UnityEngine.SceneManagement.SceneManager.activeSceneChanged += (oldScene, newScene) =>
        {
            Debug.Log("Active Scene: " + newScene);
            //async = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(oldScene);
        };
        UnityEngine.SceneManagement.SceneManager.sceneUnloaded += (scene) =>
        {
            Debug.Log("Unloaded: " + scene.name);
        };
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(defaultLevel, LoadSceneMode.Single);
        }
    }

    // Update is called once per frame
	public void BeginSceneTransition() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevel, LoadSceneMode.Single);
	}

    public void QuitGame()
    {
        Application.Quit();
    }
}
