using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentUI : MonoBehaviour
{
    public GameObject equipment_Slot;

    public EquipmentSlot Weapon;
    public EquipmentSlot Head;
    public EquipmentSlot Top;
    public EquipmentSlot Bottom;

    private void UpdateEquipment()
    {
        if (InventoryManager.Instance.weapon != null)
            Weapon.transform.GetChild(0).GetComponent<Image>().sprite = InventoryManager.Instance.weapon.Image;
        if (InventoryManager.Instance.head != null)
            Head.transform.GetChild(0).GetComponent<Image>().sprite = InventoryManager.Instance.head.Image;
        if (InventoryManager.Instance.top != null)
            Top.transform.GetChild(0).GetComponent<Image>().sprite = InventoryManager.Instance.top.Image;
        if (InventoryManager.Instance.bottom != null)
            Bottom.transform.GetChild(0).GetComponent<Image>().sprite = InventoryManager.Instance.bottom.Image;
        
    }

    private void Awake()
    {
        UIManager.Instance.equipmentUI = this;
    }

    private void Update()
    {
        UpdateEquipment();
    }
}
