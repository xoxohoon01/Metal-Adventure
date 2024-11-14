using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Equipment_Type
{
    Weapon,
    Head,
    Top,
    Bottom
}

[CreateAssetMenu(fileName = "NewItem", menuName = "Item")]
public class Item : ScriptableObject
{
    public string ItemName;
    public Sprite Image;
    public Equipment_Type Type;
    public float HP;
    public float MP;
    public float Damage;
    public float Armor;
    public float Range;
    public float MoveSpeed;
    public float AttackSpeed;
}
