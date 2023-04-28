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
    inventoryUIView.UpdateView(InventoryUIModel.inventory);
    inventoryUIView.onUse += UseItem;
}

private void UseItem(ItemData itemData)
{
    inventoryUIModel.inventory.Remove(itemData);
    inventoryUIView.UpdateView(InventoryUIModel.inventory);
}

}
