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
    private InventoryViewButton selectedButton;

    public void UpdateView(List<ItemData> items)
    {
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
        button.GetComponent<Button>().onClick.AddListener(UseItem);
    }

    private void UseItem()
    {
        onUse?.Invoke(selectedButton.itemData);
    }
}
