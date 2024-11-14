using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public Inventory()
    {
        items = new List<Item>();
    }

    private List<Item> items;
    public List<Item> Items 
    {
        get { return items; }
        set
        {
            items = value;
        }
    }

    public Action onInventoryChanged;
    
}
