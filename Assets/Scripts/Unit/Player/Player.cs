using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    public PlayerController controller;

    public Condition EXP = new Condition();

    private void Awake()
    {
        EXP.originValue = 1000.0f;
        InitCondition();

        controller = GetComponent<PlayerController>();
    }

    private void Start()
    {
        UIManager.Instance.currentPlayer = this;
    }

    private void Update()
    {
    }

    private void OnDrawGizmos()
    {
        if (characterType != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, characterType.Range);
        }
        if (Range != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, Range.GetValue());
        }
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, 100f);
    }
}
