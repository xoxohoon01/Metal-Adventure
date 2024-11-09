using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoSingleton<MonoBehaviour>
{
    public UICondition uiCondition;

    public void UpdateCondition()
    {
        uiCondition.HP.fillAmount = 0;
        uiCondition.MP.fillAmount = 0;
        uiCondition.EXP.fillAmount = 0;
    }
}
