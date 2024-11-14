using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    [SerializeField]
    private Item item;
    public Item Item
    {
        get { return item; }
        set
        {
            item = value;
            InventoryManager.Instance.inventory.onInventoryChanged.Invoke();
        }
    }
    public int slotID = -1;

    public void onClickMethod()
    {
        if (slotID != -1)
        {
            switch (item.Type)
            {
                case Equipment_Type.Weapon:
                    InventoryManager.Instance.weapon = item;
                    break;
                case Equipment_Type.Head:
                    InventoryManager.Instance.head = item;
                    break;
                case Equipment_Type.Top:
                    InventoryManager.Instance.top = item;
                    break;
                case Equipment_Type.Bottom:
                    InventoryManager.Instance.bottom = item;
                    break;
            }
        }
    }

}
