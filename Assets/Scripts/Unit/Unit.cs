using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Unit : MonoBehaviour, IDamageable
{
    public CharacterType characterType;

    public Condition HP = new Condition();
    public Condition MP = new Condition();
    public Condition Damage = new Condition();
    public Condition Armor = new Condition();
    public Condition Range = new Condition();
    public Condition MoveSpeed = new Condition();
    public Condition AttackSpeed = new Condition();

    public Action OnChangedCondition;

    public void TakeDamage(float damage)
    {
        HP.Subtract(damage);
    }

    public void InitCondition()
    {
        HP.Init(characterType.HP);
        MP.Init(characterType.MP);
        Damage.Init(characterType.Damage);
        Armor.Init(characterType.Armor);
        Range.Init(characterType.Range);
        MoveSpeed.Init(characterType.MoveSpeed);
        AttackSpeed.Init(characterType.AttackSpeed);
    }

}