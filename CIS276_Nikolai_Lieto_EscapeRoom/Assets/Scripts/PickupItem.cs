using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupItem : MonoBehaviour
{
    [SerializeField]
    private ItemData itemData;
    public InventoryController inventoryController;
    private Button button;
    void Start()
    {
        inventoryController = FindObjectOfType<InventoryController>();
        Button button = this.GetComponent<Button>();
        button.onClick.AddListener(Pickup);
    }

    private void Pickup(){
        inventoryController.GetItem(itemData);
        Destroy(gameObject);
    }
}
