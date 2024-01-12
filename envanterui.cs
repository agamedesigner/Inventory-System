using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class envanterui : MonoBehaviour
{
   public List<slotui> uiList = new List<slotui>();
   NewBehaviourScript userInventory;
    envanterui InventoryUI;
    public Sprite baslangic;
    private void Start()
    {
        userInventory=gameObject.GetComponent<NewBehaviourScript>();
        InventoryUI = gameObject.GetComponent<envanterui>();
        InventoryUI.UpdateUI();
        

    }
    public void UpdateUI()
    {
        for(int i=0; i<uiList.Count; i++)
        {
            if (userInventory.playerInventory.inventorySlots[i].itemSayi > 0)
            {
                uiList[i].itemImage.sprite = userInventory.playerInventory.inventorySlots[i].item.ItemResim;
                if (userInventory.playerInventory.inventorySlots[i].item.Birikebilir == true)
                {
                    uiList[i].itemCountText.gameObject.SetActive(true);
                    uiList[i].itemCountText.text = userInventory.playerInventory.inventorySlots[i].itemSayi.ToString();
                }
                else
                {
                    uiList[i].itemCountText.gameObject.SetActive(false);
                }

            }
            else
            {
                uiList[i].itemImage.sprite = baslangic;
                uiList[i].itemCountText.gameObject.SetActive(false);
            }
        }
    }
}
