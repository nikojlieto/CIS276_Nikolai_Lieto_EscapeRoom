using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryViewButton : MonoBehaviour
{
   public Image itemImage;
   public ItemData itemData;
   public InventoryUIView view;

   private void Awake()
   {
    GetComponent<Button>().onClick.AddListener(ButtonClicked);
   }

   private void ButtonClicked()
   {
    view.InventoryItemClicked(this);
   }
}
