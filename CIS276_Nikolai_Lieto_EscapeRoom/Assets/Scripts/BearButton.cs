using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BearButton : MonoBehaviour
{
    private Button button;
    [SerializeField]
    private BearPuzzleTracker bearPuzzleTracker;
    void Start(){
        button = GetComponent<Button>();
        //this is extra/unecessary
        button.onClick.AddListener(BearClick);
    }

    public void BearClick(){
        bearPuzzleTracker.CheckSequence(button);
    }
}
