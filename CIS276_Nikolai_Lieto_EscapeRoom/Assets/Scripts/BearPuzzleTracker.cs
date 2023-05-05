using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class BearPuzzleTracker : MonoBehaviour
{
    //nose left paw right paw right foot left foot
    [SerializeField]
    Button nose, lpaw, rpaw, rfoot, lfoot;
    Button[] correctSequence;
    Button[] playerSequence;
    int sequencePoint;
    public InventoryController inventoryController;
    [SerializeField]
    ItemData reward;
    [SerializeField]
    GameTracker gameTracker;
    [SerializeField]
    private AudioSource successNoise;

    void Start(){
        correctSequence = new Button[]{nose, lpaw, rpaw, rfoot, lfoot};
        playerSequence = new Button[5];
        sequencePoint = 0;
        inventoryController = InventoryController.FindObjectOfType<InventoryController>();
    }

    public void CheckSequence(Button latest){
        playerSequence[sequencePoint] = latest;
        if(latest!= correctSequence[sequencePoint]){
            Debug.Log("oogie...");
            Debug.Log(latest);
            Debug.Log(correctSequence[sequencePoint]);
            sequencePoint = 0;
        } else {
            Debug.Log("yup yup");
            sequencePoint++;
            if(playerSequence.SequenceEqual(correctSequence)){
                Debug.Log("all done!");
                inventoryController.GetItem(reward);
                successNoise.Play(0);
                gameTracker.deskKey1 = true;
                Destroy(nose);
                Destroy(lpaw);
                Destroy(rpaw);
                Destroy(rfoot);
                Destroy(lfoot);
            }
        }
                
    }
}
