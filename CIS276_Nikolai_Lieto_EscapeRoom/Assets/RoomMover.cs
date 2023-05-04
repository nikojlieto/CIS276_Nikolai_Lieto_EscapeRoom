using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomMover : MonoBehaviour
{
    [SerializeField]
    private Button loadSceneButton;

    private void Start(){
        loadSceneButton.onClick.AddListener(LoadScene);
    }

    public void LoadScene(){
        GameObject leftPuzzle = GameObject.Find("LeftPuzzle");
        leftPuzzle.SetActive(true);
    }
}
