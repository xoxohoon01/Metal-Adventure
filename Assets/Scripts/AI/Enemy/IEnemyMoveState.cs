using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEnemyMoveState : IEnemyState
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
        if (controller.DistanceToAttack())
        {
            controller.ChangeState(new IEnemyAttackState());
        }
        controller.rb.velocity = (controller.target.transform.position - controller.transform.position).normalized * controller.enemy.MoveSpeed.curValue;
    }

    public void OnExit(EnemyController controller)
    {

    }
}
