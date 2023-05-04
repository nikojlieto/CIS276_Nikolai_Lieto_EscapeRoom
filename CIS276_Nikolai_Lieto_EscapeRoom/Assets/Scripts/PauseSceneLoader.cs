using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseSceneLoader : MonoBehaviour
{
    public const string PAUSE_SCENE = "PauseScene";
    public Scene currentScene;
    [SerializeField]
    private Button loadSceneButton;
    private void Start()
    {
        loadSceneButton.onClick.AddListener(LoadScene);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(PAUSE_SCENE, LoadSceneMode.Additive);
    }
}
