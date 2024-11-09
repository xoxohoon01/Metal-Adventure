using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICondition : MonoBehaviour
{
    public Image HP;
    public Image MP;
    public Image EXP;
    private void Awake()
    {
        UIManager.Instance.uiCondition = this;
    }
}
