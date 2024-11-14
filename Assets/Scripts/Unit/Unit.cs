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
    

    public void UpdateBuff()
    {
        #region HP
        if (HP.multiplication.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in HP.multiplication)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            HP.multiplication.RemoveAll(removeBuffs.Contains);
        }
        if (HP.addition.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in HP.addition)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            HP.addition.RemoveAll(removeBuffs.Contains);
        }
        if (HP.subtraction.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in HP.subtraction)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            HP.subtraction.RemoveAll(removeBuffs.Contains);
        }
        #endregion

        #region MP
        if (MP.multiplication.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in MP.multiplication)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            MP.multiplication.RemoveAll(removeBuffs.Contains);
        }
        if (MP.addition.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in MP.addition)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            MP.addition.RemoveAll(removeBuffs.Contains);
        }
        if (MP.subtraction.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in MP.subtraction)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            MP.subtraction.RemoveAll(removeBuffs.Contains);
        }
        #endregion

        #region Damage
        if (Damage.multiplication.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in Damage.multiplication)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            Damage.multiplication.RemoveAll(removeBuffs.Contains);
        }
        if (Damage.addition.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in Damage.addition)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            Damage.addition.RemoveAll(removeBuffs.Contains);
        }
        if (Damage.subtraction.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in Damage.subtraction)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            Damage.subtraction.RemoveAll(removeBuffs.Contains);
        }
        Damage.UpdateValue();
        #endregion

        #region Armor
        if (Armor.multiplication.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in Armor.multiplication)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            Armor.multiplication.RemoveAll(removeBuffs.Contains);
        }
        if (Armor.addition.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in Armor.addition)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            Armor.addition.RemoveAll(removeBuffs.Contains);
        }
        if (Armor.subtraction.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in Armor.subtraction)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            Armor.subtraction.RemoveAll(removeBuffs.Contains);
        }
        Armor.UpdateValue();
        #endregion

        #region Range
        if (Range.multiplication.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in Range.multiplication)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            Range.multiplication.RemoveAll(removeBuffs.Contains);
        }
        if (Range.addition.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in Range.addition)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            Range.addition.RemoveAll(removeBuffs.Contains);
        }
        if (Range.subtraction.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in Range.subtraction)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            Range.subtraction.RemoveAll(removeBuffs.Contains);
        }
        Range.UpdateValue();
        #endregion

        #region MoveSpeed
        if (MoveSpeed.multiplication.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in MoveSpeed.multiplication)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            MoveSpeed.multiplication.RemoveAll(removeBuffs.Contains);
        }
        if (MoveSpeed.addition.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in MoveSpeed.addition)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            MoveSpeed.addition.RemoveAll(removeBuffs.Contains);
        }
        if (MoveSpeed.subtraction.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in MoveSpeed.subtraction)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            MoveSpeed.subtraction.RemoveAll(removeBuffs.Contains);
        }
        MoveSpeed.UpdateValue();
        #endregion

        #region AttackSpeed
        if (AttackSpeed.multiplication.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in AttackSpeed.multiplication)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            AttackSpeed.multiplication.RemoveAll(removeBuffs.Contains);
        }
        if (AttackSpeed.addition.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in AttackSpeed.addition)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            AttackSpeed.addition.RemoveAll(removeBuffs.Contains);
        }
        if (AttackSpeed.subtraction.Count > 0)
        {
            List<Buff> removeBuffs = new List<Buff>();
            foreach (Buff buff in AttackSpeed.subtraction)
            {
                if (buff.span <= 0) removeBuffs.Add(buff);
                buff.span -= Time.deltaTime;
            }
            AttackSpeed.subtraction.RemoveAll(removeBuffs.Contains);
        }
        AttackSpeed.UpdateValue();
        #endregion
    }

}