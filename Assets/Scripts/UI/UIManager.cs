using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{
    public UICondition uiCondition;

    public Action updateUI;

    public Character currentCharacter;

    public void UpdateCondition()
    {
        if (currentCharacter != null)
        {
            uiCondition.HP.fillAmount = currentCharacter.HP.curValue / currentCharacter.HP.GetValue();
            uiCondition.MP.fillAmount = currentCharacter.MP.curValue / currentCharacter.MP.GetValue();
            uiCondition.EXP.fillAmount = currentCharacter.EXP.curValue / currentCharacter.EXP.GetValue();
        }
    }
}
