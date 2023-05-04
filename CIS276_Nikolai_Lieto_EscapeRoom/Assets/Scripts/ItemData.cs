using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemCategory {Information, Usable}
[CreateAssetMenu(fileName = "New Item Data", menuName = "Items/ItemData")]
public class ItemData : ScriptableObject
{
    [field:SerializeField]
    public ItemCategory category {get; private set;}
    [field:SerializeField]
    public Sprite itemSprite;
}
