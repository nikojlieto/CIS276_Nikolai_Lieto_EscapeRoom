using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI textField;

    public void changeText(string desc){
        textField.text = desc;
    }
}
