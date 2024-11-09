using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Condition
{
    public float curValue;
    public float originValue;

    public List<float> addition;
    public List<float> multiplication;
    public List<float> subtraction;

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
