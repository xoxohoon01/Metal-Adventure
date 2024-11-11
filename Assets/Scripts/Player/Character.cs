using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : Unit
{
    public Condition EXP = new Condition();

    private void Awake()
    {
        EXP.originValue = 1000.0f;
        InitCondition();
    }

    private void Start()
    {
        UIManager.Instance.currentCharacter = this;
    }

    private void Update()
    {
    }
}
