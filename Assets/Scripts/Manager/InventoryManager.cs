using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoSingleton<InventoryManager>
{
    public int gold;
    public Inventory inventory;
    public Item weapon;
    public Item head;
    public Item top;
    public Item bottom;

    private void Start()
    {
        inventory = new Inventory();
        UIManager.Instance.inventoryUI.currentInventory = inventory; ;
    }
}
