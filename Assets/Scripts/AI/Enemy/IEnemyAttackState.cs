using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEnemyAttackState : IEnemyState
{
    public void OnStart(EnemyController controller)
    {

    }

    public void OnUpdate(EnemyController controller)
    {
        if (!controller.FindTarget())
        {
            controller.ChangeState(new IEnemyIdleState());
        }
    }

    public void OnExit(EnemyController controller)
    {

    }
}
