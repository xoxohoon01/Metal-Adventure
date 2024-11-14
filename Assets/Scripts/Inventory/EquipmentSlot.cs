using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class EquipmentSlot : MonoBehaviour
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
        switch (slotID)
        {
            case 0:
                InventoryManager.Instance.weapon = null;
                break;
            case 1:
                InventoryManager.Instance.head = null;
                break;
            case 2:
                InventoryManager.Instance.top = null;
                break;
            case 3:
                InventoryManager.Instance.bottom = null;
                break;
        }
    }

    private void Update()
    {
        switch (slotID)
        {
            case 0:
                item = InventoryManager.Instance.weapon;
                break;
            case 1:
                item = InventoryManager.Instance.head;
                break;
            case 2:
                item = InventoryManager.Instance.top;
                break;
            case 3:
                item = InventoryManager.Instance.bottom;
                break;
        }
    }

}
