using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckNumbers : MonoBehaviour
{
    [SerializeField]
    public InventoryController inventoryController;
    [SerializeField]
    Button checkButton;
    [SerializeField]
    private TMP_InputField inputField;
    [SerializeField]
    private ItemData reward;
    [SerializeField]
    private AudioSource successNoise;
    [SerializeField]
    private GameTracker gameTracker;
    void Start()
    {
        //inputField = gameObject.GetComponent<InputField>();
        checkButton.onClick.AddListener(checkPuzzle);
    }

    public void checkPuzzle(){
        if (inputField.text == "2589"){
            inventoryController.GetItem(reward);
            successNoise.Play(0);
            gameTracker.deskKey2 = true;
            Destroy(checkButton);
        }
    }

}
