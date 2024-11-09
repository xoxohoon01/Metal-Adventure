using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{
    public UICondition uiCondition;

    public Action updateUI;

    public Condition HP;
    public Condition MP;
    public Condition EXP;

    public void UpdateCondition()
    {
        uiCondition.HP.fillAmount = HP.GetValue() / HP.curValue;
        uiCondition.MP.fillAmount = MP.GetValue() / MP.curValue;
        uiCondition.EXP.fillAmount = EXP.GetValue() / EXP.curValue;
    }

    private void OnEnable()
    {
        updateUI += UpdateCondition;
    }
}
