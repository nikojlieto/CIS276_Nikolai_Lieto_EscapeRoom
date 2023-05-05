using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomMover : MonoBehaviour
{
    [SerializeField]
    private Button  enterBearPuzzle, enterBookClueScreen, exitBearPuzzle, exitBookClueScreen,
                    leftMoveButton,
                    centerLeftMoveButton, centerRightMoveButton,
                    rightMoveButton,
                    enterBoxPuzzle, enterShelfClueScreen, exitBoxPuzzle, exitShelfClueScreen,
                    endDoor;
    [SerializeField]
    private GameObject  UIElements, 
                        LeftRoom, LeftInfo, LeftPuzzle, 
                        CenterRoom, 
                        RightRoom, RightInfo, RightPuzzle,
                        EndScreen;
    [SerializeField]
    private InventoryUIView inventoryUIView;
    [SerializeField]
    private InventoryController inventoryController;
    [SerializeField]
    private ItemData bearUnlockItemData, boxUnlockItemData, endData;
    bool leftPuzzleUnlock;
    bool rightPuzzleUnlock;

    private void Start(){
        leftPuzzleUnlock = false;
        rightPuzzleUnlock = false;
        enterBearPuzzle.onClick.AddListener(CheckBearPuzzle);
        enterBookClueScreen.onClick.AddListener(EnterBookClueScreen);
        exitBearPuzzle.onClick.AddListener(ExitBearPuzzle);
        exitBookClueScreen.onClick.AddListener(ExitBookClueScreen);
        leftMoveButton.onClick.AddListener(EnterCenterScreen);
        centerLeftMoveButton.onClick.AddListener(EnterLeftScreen);
        centerRightMoveButton.onClick.AddListener(EnterRightScreen);
        rightMoveButton.onClick.AddListener(EnterCenterScreen2);
        enterBoxPuzzle.onClick.AddListener(CheckBoxPuzzle);
        enterShelfClueScreen.onClick.AddListener(EnterShelfClueScreen);
        exitBoxPuzzle.onClick.AddListener(ExitBoxPuzzle);
        exitShelfClueScreen.onClick.AddListener(ExitShelfClueScreen);
        endDoor.onClick.AddListener(EndGame);
    }

    public void CheckBearPuzzle(){
        if(leftPuzzleUnlock){
            EnterBearPuzzle();
        } else if (inventoryUIView.selectedButton != null){
            if (inventoryUIView.selectedButton.itemData == bearUnlockItemData){
            leftPuzzleUnlock = true;
            inventoryController.UseItem(inventoryUIView.selectedButton.itemData);
            EnterBearPuzzle();
        }
        }
    }

    public void EnterBearPuzzle(){
        LeftPuzzle.SetActive(true);
        LeftRoom.SetActive(false);
        UIElements.SetActive(false);
    }
    public void EnterBookClueScreen(){
        LeftInfo.SetActive(true);
        LeftRoom.SetActive(false);
        UIElements.SetActive(false); 
    }
    public void ExitBearPuzzle(){
        LeftPuzzle.SetActive(false);
        LeftRoom.SetActive(true);
        UIElements.SetActive(true);
    }
    public void ExitBookClueScreen(){
        LeftInfo.SetActive(false);
        LeftRoom.SetActive(true);
        UIElements.SetActive(true);
    }
    public void EnterCenterScreen(){
        CenterRoom.SetActive(true);
        LeftRoom.SetActive(false);
    }
    public void EnterLeftScreen(){
        CenterRoom.SetActive(false);
        LeftRoom.SetActive(true);
    }
    public void EnterRightScreen(){
        CenterRoom.SetActive(false);
        RightRoom.SetActive(true);
    }
    public void EnterCenterScreen2(){
        CenterRoom.SetActive(true);
        RightRoom.SetActive(false);
    }
    public void CheckBoxPuzzle(){
        if(rightPuzzleUnlock){
            EnterBoxPuzzle();
        } else if (inventoryUIView.selectedButton != null){
        if (inventoryUIView.selectedButton.itemData == boxUnlockItemData){
            rightPuzzleUnlock = true;
            inventoryController.UseItem(inventoryUIView.selectedButton.itemData);
            EnterBoxPuzzle();
        }
    }
    }
    public void EnterBoxPuzzle(){
        RightPuzzle.SetActive(true);
        RightRoom.SetActive(false);
        UIElements.SetActive(false);
    }
    public void ExitBoxPuzzle(){
        RightPuzzle.SetActive(false);
        RightRoom.SetActive(true);
        UIElements.SetActive(true);
    }
    public void EnterShelfClueScreen(){
        RightInfo.SetActive(true);
        RightRoom.SetActive(false);
        UIElements.SetActive(false); 
    }
    public void ExitShelfClueScreen(){
        RightInfo.SetActive(false);
        RightRoom.SetActive(true);
        UIElements.SetActive(true); 
    }

       private void EndGame(){
        if(inventoryUIView.selectedButton != null){
            if(inventoryUIView.selectedButton.itemData == endData){
                CenterRoom.SetActive(false);
                EndScreen.SetActive(true);
                UIElements.SetActive(false);
            }
        }
    }
}
