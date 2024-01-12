using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public scenvanter playerInventory;
    envanterui InventoryUI;

    bool isSwapping;
    int tempIndex;
    Slot tempSlot;


    private void Start()
    {
        InventoryUI = gameObject.GetComponent<envanterui>();

    }
    public void SwapItem(int index)
    {
        if (isSwapping == false)
        {
            tempIndex = index;
            tempSlot = playerInventory.inventorySlots[tempIndex];
            isSwapping = true;
        }
        else if (isSwapping==true)
        {
            playerInventory.inventorySlots[tempIndex]= playerInventory.inventorySlots[index];
            playerInventory.inventorySlots[index] = tempSlot;
            isSwapping=false;
        }
        InventoryUI.UpdateUI();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            if (playerInventory.AddItem(other.gameObject.GetComponent<Item>().item))
            {
                Destroy(other.gameObject);
                InventoryUI.UpdateUI();
            }
            
        }
        if (other.gameObject.CompareTag("item1"))
        {
            if (playerInventory.AddItem(other.gameObject.GetComponent<Item>().item))
            {
                Destroy(other.gameObject);
                InventoryUI.UpdateUI();
            }

        }
        if (other.gameObject.CompareTag("item2"))
        {
            if (playerInventory.AddItem(other.gameObject.GetComponent<Item>().item))
            {
                Destroy(other.gameObject);
                InventoryUI.UpdateUI();
            }

        }
        
    }

}
