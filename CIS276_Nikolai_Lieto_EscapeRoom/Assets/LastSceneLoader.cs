using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LastSceneLoader : MonoBehaviour
{
    [SerializeField]
    private Button loadSceneButton;
    private Scene PAUSE_SCENE;
    private void Start()
    {
        loadSceneButton.onClick.AddListener(LoadScene);
    }

    public void LoadScene()
    {
        SceneManager.UnloadSceneAsync("PauseScene");
    }
}
