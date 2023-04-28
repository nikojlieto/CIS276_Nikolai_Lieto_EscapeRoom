using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShelfSceneLoader : MonoBehaviour
{
    [SerializeField]
    private Button loadSceneButton;
    private void Start()
    {
        loadSceneButton.onClick.AddListener(LoadScene);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("RightScene", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("RightShelfScene");
    }
}
