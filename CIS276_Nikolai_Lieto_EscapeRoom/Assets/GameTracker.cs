using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTracker : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI textField;
    public int gameStateA = 0;
    public int gameStateB = 0;
    public string currentTextDescription = "";
    void Start()
    {
        textField.text = currentTextDescription;
    }
}
