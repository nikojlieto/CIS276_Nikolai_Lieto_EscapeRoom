using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RightSceneLoader : MonoBehaviour
{
   public const string GAME_SCENE = "CenterScene";
    [SerializeField]
    private Button loadSceneButton;
    [SerializeField]
    private Button loadShelfButton;
    private void Start()
    {
        loadSceneButton.onClick.AddListener(LoadScene);
        loadShelfButton.onClick.AddListener(LoadShelf);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(GAME_SCENE);
        SceneManager.LoadScene("DisplayScene", LoadSceneMode.Additive);
    }

    public void LoadShelf()
    {
        SceneManager.LoadScene("RightShelfScene");
    }
}
