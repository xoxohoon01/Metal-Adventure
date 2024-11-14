using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventory_Slot;
    public Inventory currentInventory;
    private List<InventorySlot> inventorySlots = new List<InventorySlot>();

    private void UpdateInventory()
    {
        for (int i = 0; i < inventorySlots.Count; i++)
        {
            if (inventorySlots[i].GetComponent<InventorySlot>().Item != null)
                inventorySlots[i].transform.GetChild(0).GetComponent<Image>().sprite = inventorySlots[i].Item.Image;
        }
    }

    private void Awake()
    {
        UIManager.Instance.inventoryUI = this;

        inventorySlots.Clear();
        for (int i = 0; i < 25; i++)
        {
            inventorySlots.Add(Instantiate(inventory_Slot, transform).GetComponent<InventorySlot>());
            inventorySlots[i].slotID = i;
        }
    }

    private void Update()
    {
        UpdateInventory();
    }

}
