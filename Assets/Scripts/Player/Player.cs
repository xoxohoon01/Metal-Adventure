using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, Unit
{
    Condition HP;
    Condition MP;
    Condition EXP;

    public void OnDamage(float damage)
    {
        HP.curValue -= damage;
    }

    private void OnEnable()
    {
        UIManager.Instance.HP = HP;
        UIManager.Instance.MP = MP;
        UIManager.Instance.EXP = EXP;
        UIManager.Instance.updateUI.Invoke();
    }
}
