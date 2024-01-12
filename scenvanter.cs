using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "Scriptable/Inventory")]
public class scenvanter : ScriptableObject
{
   public List<Slot> inventorySlots = new List<Slot>();
    int stackLimit = 15;
    public bool AddItem(envanteryapisi item)
    {
        foreach (Slot slot in inventorySlots)
        {
            if (slot.item == item)
            {
                if (slot.item.Birikebilir)
                {
                    if (slot.itemSayi < stackLimit)
                    {
                        slot.itemSayi++;
                        if (slot.itemSayi >= stackLimit)
                        {
                            slot.isFull = true;
                        }
                        return true;
                    }
                }
            }
            else if (slot.itemSayi==0)
            {
                slot.AddItemToSlot(item);
                return true;
            }
            
        }
        return false;
    }
}
[System.Serializable]
public class Slot
{
    public bool isFull;
    public int itemSayi;
    public envanteryapisi item;
    public void AddItemToSlot(envanteryapisi item)
    {
        this.item = item;
        if(item.Birikebilir == false)
        {
            isFull = true;
        }
        itemSayi++;
           
    }
}
