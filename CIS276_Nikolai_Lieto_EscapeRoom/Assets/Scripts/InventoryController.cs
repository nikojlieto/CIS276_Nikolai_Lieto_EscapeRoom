using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
[SerializeField]
private InventoryUIModel inventoryUIModel;
[SerializeField]
private InventoryUIView inventoryUIView;

private void Start()
{
    inventoryUIView.UpdateView(inventoryUIModel.inventory);
    inventoryUIView.onUse += UseItem;
}

public void UseItem(ItemData itemData)
{
    inventoryUIModel.inventory.Remove(itemData);
    inventoryUIView.selectedButton = null;
    inventoryUIView.UpdateView(inventoryUIModel.inventory);
}

public void GetItem(ItemData itemData)
{
    inventoryUIModel.inventory.Add(itemData);
    inventoryUIView.UpdateView(inventoryUIModel.inventory);
}
}


