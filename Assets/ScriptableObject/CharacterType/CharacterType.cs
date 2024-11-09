using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "CharacterType")]
public class CharacterType : ScriptableObject
{
    public float HP;
    public float MP;
    public float Damage;
    public float Armor;
    public float Range;
    public float MoveSpeed;
    public float AttackSpeed;
}
