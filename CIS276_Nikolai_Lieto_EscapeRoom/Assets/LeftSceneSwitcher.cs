using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeftSceneSwitcher : MonoBehaviour
{
public const string GAME_SCENE = "CenterScene";
    [SerializeField]
    private Button loadSceneButton;
    [SerializeField]
    private Button loadBooksButton;
    private void Start()
    {
        loadSceneButton.onClick.AddListener(LoadScene);
        loadBooksButton.onClick.AddListener(LoadBooks);
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(GAME_SCENE);

    }
    public void LoadBooks()
    {
        SceneManager.LoadScene("BooksLeftScene");

    }
}
