using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTracker : MonoBehaviour
{
    public bool bearUnlocked = false;
    public bool boxUnlocked = false;
    public bool deskKey1 = false;
    public bool deskKey2 = false;
    //bool smallDoorUnlocked;
    [SerializeField]
    private Button smallDoor, shinyKey, twoDesk, endDoor;
    [SerializeField]
    private InventoryUIView inventoryUIView;
    [SerializeField]
    private InventoryController inventoryController;
    [SerializeField]
    private ItemData smallDoorUnlockItemData, deskItem1, deskItem2;

    private void Start(){
        //smallDoorUnlocked = false;
        shinyKey.interactable = false;
        smallDoor.onClick.AddListener(CheckSmallDoor);
        twoDesk.onClick.AddListener(CheckTwoDesk);
    }


    private void CheckTwoDesk(){
        if(deskKey1 && deskKey2){
            inventoryController.UseItem(deskItem1);
            inventoryController.UseItem(deskItem2);
            inventoryController.GetItem(smallDoorUnlockItemData);
        }
    }
    private void CheckSmallDoor(){
        if (inventoryUIView.selectedButton != null){
            if(inventoryUIView.selectedButton.itemData == smallDoorUnlockItemData){
            shinyKey.interactable = true;
            inventoryController.UseItem(smallDoorUnlockItemData);            }
        }
        
    }

    public void UnlockBear(){
        bearUnlocked = true;
    }
    public void UnlockBox(){
        boxUnlocked = true;
    }
}
