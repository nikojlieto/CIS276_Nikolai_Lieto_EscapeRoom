using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RealCenterSceneLoader : MonoBehaviour
{
public const string LEFT_SCENE = "LeftScene";
public const string RIGHT_SCENE = "RightScene";
    [SerializeField]
    private Button loadLeftSceneButton;
    [SerializeField]
    private Button loadRightSceneButton;
    private void Start()
    {
        loadLeftSceneButton.onClick.AddListener(LoadLeftScene);
        loadRightSceneButton.onClick.AddListener(LoadRightScene);
    }

    public void LoadLeftScene()
    {
        SceneManager.LoadScene(LEFT_SCENE);
        SceneManager.LoadScene("DisplayScene", LoadSceneMode.Additive);
    }

    public void LoadRightScene()
    {
        SceneManager.LoadScene(RIGHT_SCENE);
        SceneManager.LoadScene("DisplayScene", LoadSceneMode.Additive);
    }
}

