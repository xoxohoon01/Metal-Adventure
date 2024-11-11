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

    public List<float> addition = new List<float>();
    public List<float> multiplication = new List<float>();
    public List<float> subtraction = new List<float>();

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
    }
    public void Subtract(float value)
    {
        curValue -= value;
    }
    public float GetValue()
    {
        float finalValue = originValue;

        if (multiplication.Count > 0) finalValue *= 1 + multiplication.Sum();
        if (addition.Count > 0)
        {
            for (int i = 0; i < addition.Count; i++)
            {
                finalValue += addition[i];
            }
        }
        if (subtraction.Count > 0)
        {
            for (int i = 0; i < addition.Count; i++)
            {
                finalValue -= addition[i];
            }
        }

        return Mathf.Max(0, finalValue);
    }
}
