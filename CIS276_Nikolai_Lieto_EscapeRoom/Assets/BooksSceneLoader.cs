using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BooksSceneLoader : MonoBehaviour
{
public const string LEFT_SCENE = "LeftScene";
    [SerializeField]
    private Button loadSceneButton;
    private void Start()
    {
        loadSceneButton.onClick.AddListener(LoadScene);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(LEFT_SCENE);
        SceneManager.LoadScene("DisplayScene", LoadSceneMode.Additive);
    }
}

