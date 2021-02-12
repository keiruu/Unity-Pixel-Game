using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    [Header("UI things")]
    [SerializeField] private TextMeshProUGUI itemNumberText;
    [SerializeField] private Image itemImage;
    
    [Header("Variables")]
    public InventoryItem thisItem;
    public InventoryManager thisManager;
    
    public void Setup(InventoryItem newItem, InventoryManager newManager)
    {
        thisItem = newItem;
        thisManager = newManager;
        if(thisItem)
        {
            itemImage.sprite = thisItem.itemImage;
            itemNumberText.text = "" + thisItem.numberHeld;
        }
    }

    public void ClickedOn(){
        if(thisItem){
            thisManager.Setup(thisItem.itemDescription, thisItem.itemName, thisItem.usable, thisItem.itemImage, thisItem);
        }

    }
}
