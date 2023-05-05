using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIView : MonoBehaviour
{
    public event Action<ItemData> onUse;
    public Action<ItemData> onPickup;
    [SerializeField]
    private GameObject itemButtonPrefab;
    [SerializeField]
    private Transform inventoryGrid;
    public InventoryViewButton selectedButton;

    public void UpdateView(List<ItemData> items)
    {
        for (int i = 0; i < inventoryGrid.transform.childCount; i++){
            Destroy(inventoryGrid.transform.GetChild(i).gameObject);
        }
             
        foreach(ItemData item in items)
        {
            InventoryViewButton button = Instantiate(itemButtonPrefab, inventoryGrid).GetComponent<InventoryViewButton>();
            button.view = this;
            button.itemData = item;
            button.itemImage.sprite = item.itemSprite;
        }
    }

    public void InventoryItemClicked(InventoryViewButton button)
    {
        selectedButton = button;
        //button.GetComponent<Button>().onClick.AddListener(UseItem);
    }

    private void UseItem()
    {
        onUse?.Invoke(selectedButton.itemData);
    }
}
