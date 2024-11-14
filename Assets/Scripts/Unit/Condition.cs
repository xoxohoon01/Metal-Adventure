using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class Condition
{
    [SerializeField]
    private float _curValue = 0;
    public float curValue
    {
        get
        {
            return _curValue;
        }
        set
        {
            _curValue = value;
            if (OnCurValueChanged != null)
            {
                OnCurValueChanged.Invoke();
            }
            UIManager.Instance.UpdateCondition();
        }
    }

    [SerializeField]
    private float _originValue = 0;
    public float originValue
    {
        get
        {
            return _originValue;
        }
        set
        {
            _originValue = value;
            if (OnOriginValueChanged != null)
            {
                OnOriginValueChanged.Invoke();
            }
                
            UIManager.Instance.UpdateCondition();
        }
    }

    public List<Buff> addition = new List<Buff>();
    public List<Buff> multiplication = new List<Buff>();
    public List<Buff> subtraction = new List<Buff>();

    public Action OnCurValueChanged;
    public Action OnOriginValueChanged;

    public void Init(float value)
    {
        originValue = value;
        curValue = value;
    }
    public void Add(float value)
    {
        curValue += value;
        curValue = Mathf.Clamp(curValue, 0, GetValue());
    }
    public void Subtract(float value)
    {
        curValue -= value;
    }
    public float GetValue()
    {
        float finalValue = originValue;

        if (multiplication.Count > 0)
        {
            float value = 0;
            foreach(Buff buff in multiplication)
            {
                value += buff.buffValue;
            }
            finalValue *= 1 + value;
        }
        if (addition.Count > 0)
        {
            for (int i = 0; i < addition.Count; i++)
            {
                finalValue += addition[i].buffValue;
            }
        }
        if (subtraction.Count > 0)
        {
            for (int i = 0; i < addition.Count; i++)
            {
                finalValue -= addition[i].buffValue;
            }
        }

        return Mathf.Max(0, finalValue);
    }

    public void AddBuffAddition(Buff newBuff, bool isChangeCurValue = false)
    {
        addition.Add(newBuff);
        curValue = isChangeCurValue ? GetValue() : curValue;
    }
    public void AddBuffMultiplication(Buff newBuff, bool isChangeCurValue = false)
    {
        multiplication.Add(newBuff);
        curValue = isChangeCurValue ? GetValue() : curValue;
    }
    public void AddBuffSubtraction(Buff newBuff, bool isChangeCurValue = false)
    {
        subtraction.Add(newBuff);
        curValue = isChangeCurValue ? GetValue() : curValue;
    }

    public void UpdateValue()
    {
        curValue = GetValue();
    }
}
