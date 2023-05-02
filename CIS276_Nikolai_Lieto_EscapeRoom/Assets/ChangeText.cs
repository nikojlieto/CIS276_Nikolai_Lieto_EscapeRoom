using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField]
    private Button button;
    [SerializeField]
    private string text;
    [SerializeField]
    private ItemData correctItem;
    //gameManager path 

    private void Awake()
    {
        button = GetComponent<Button>(); 
        if (button != null)
        {
            button.onClick.AddListener(UpdateTextChanger);
        }
    }

    private void OnDestroy()
    {
        if (button != null)
        {
            button.onClick.RemoveListener(UpdateTextChanger);
        }
    }

    private void UpdateTextChanger()
    {
        //check if item is null first, default text
        //if current item is correct item
        //gamemanager route ++ 
        //alternate text
        //else 
        TextChanger.instance.changeText(text);
    }
}

