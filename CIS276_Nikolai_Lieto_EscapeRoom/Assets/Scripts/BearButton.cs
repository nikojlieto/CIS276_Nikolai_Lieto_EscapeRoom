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
        Button button = this.GetComponent<Button>();
        button.onClick.AddListener(BearClick);
    }

    public void BearClick(){
        bearPuzzleTracker.CheckSequence(button);
    }
}
