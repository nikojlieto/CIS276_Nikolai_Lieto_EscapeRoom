using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BearPuzzleTracker : MonoBehaviour
{
    //nose left paw right paw right foot left foot
    [SerializeField]
    Button nose;
    [SerializeField]
    Button lpaw;
    [SerializeField]
    Button rpaw;
    [SerializeField]
    Button rfoot;
    [SerializeField]
    Button lfoot;
    Button[] correctSequence;
    Button[] playerSequence;
    int sequencePoint;
    public InventoryController inventoryController;
    [SerializeField]
    ItemData reward;

    void Start(){
        correctSequence = new Button[]{nose, lpaw, rpaw, rfoot, lfoot};
        playerSequence = new Button[5];
        sequencePoint = 0;
        inventoryController = InventoryController.FindObjectOfType<InventoryController>();
    }

    public void CheckSequence(Button latest){
        playerSequence[sequencePoint] = latest;
        if(playerSequence == correctSequence){
            Debug.Log("all done!");
            inventoryController.GetItem(reward);
            Destroy(nose);
            Destroy(lpaw);
            Destroy(rpaw);
            Destroy(rfoot);
            Destroy(lfoot);
        } else {
            if(latest!= correctSequence[sequencePoint]){
                Debug.Log("oogie...");
                sequencePoint = 0;
            }
        }
                sequencePoint++;
    }
}
