using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Unit
{
    public EnemyController controller { get; private set; }

    private void Awake()
    {
        InitCondition();
        controller = GetComponent<EnemyController>();
    }
    private void Update()
    {
        UpdateBuff();
    }
}
