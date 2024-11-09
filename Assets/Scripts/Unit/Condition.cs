using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class Condition
{
    public float curValue = 0;
    public float originValue = 0;

    public List<float> addition = new List<float>();
    public List<float> multiplication = new List<float>();
    public List<float> subtraction = new List<float>();

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

        if (multiplication.Count > 0) finalValue *= multiplication.Sum();
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
