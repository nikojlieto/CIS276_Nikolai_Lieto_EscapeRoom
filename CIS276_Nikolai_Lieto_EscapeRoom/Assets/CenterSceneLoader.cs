using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CenterSceneLoader : MonoBehaviour
{
public const string GAME_SCENE = "CenterScene";
    [SerializeField]
    private Button loadSceneButton;
    private void Start()
    {
        loadSceneButton.onClick.AddListener(LoadScene);
    }

    public void LoadScene()
    {
        Debug.Log("loaded!");
        SceneManager.LoadScene(GAME_SCENE);
        SceneManager.LoadScene("DisplayScene", LoadSceneMode.Additive);
    }
}
