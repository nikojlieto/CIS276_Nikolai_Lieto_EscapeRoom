using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveItemButton : MonoBehaviour
{
    public InventoryUIView inventoryUIView;
 void Start()
    {
        inventoryUIView = InventoryUIView.FindObjectOfType<InventoryUIView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inventoryUIView.selectedButton != null){
            this.GetComponent<Button>().image.sprite = inventoryUIView.selectedButton.itemImage.sprite;
        }
        
    }
}
