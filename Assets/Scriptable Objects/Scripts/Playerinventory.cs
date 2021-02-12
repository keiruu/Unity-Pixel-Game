using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory/PlayerInventory")]
public class Playerinventory : ScriptableObject
{
    public List<InventoryItem> myInventory = new List<InventoryItem>();
}
