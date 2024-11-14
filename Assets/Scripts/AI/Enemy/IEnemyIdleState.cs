using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEnemyIdleState : IEnemyState
{
    public void OnStart(EnemyController controller)
    {

    }

    public void OnUpdate(EnemyController controller)
    {
        if (controller.FindTarget())
        {
            controller.ChangeState(new IEnemyAttackState());
        }
    }

    public void OnExit(EnemyController controller)
    {

    }
}
