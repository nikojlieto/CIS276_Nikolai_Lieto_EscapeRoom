using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI textField;
    public static TextChanger instance; 

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void changeText(string desc){
        textField.text = desc;
    }
}
