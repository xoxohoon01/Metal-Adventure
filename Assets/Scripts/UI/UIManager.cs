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

    public Player currentPlayer;

    public void UpdateCondition()
    {
        if (currentPlayer != null)
        {
            uiCondition.HP.fillAmount = currentPlayer.HP.curValue / currentPlayer.HP.GetValue();
            uiCondition.MP.fillAmount = currentPlayer.MP.curValue / currentPlayer.MP.GetValue();
            uiCondition.EXP.fillAmount = currentPlayer.EXP.curValue / currentPlayer.EXP.GetValue();
        }
    }
}
