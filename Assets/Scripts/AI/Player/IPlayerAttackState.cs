using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPlayerAttackState : IPlayerState
{
    public void OnStart(PlayerController controller)
    {
        controller.rb.velocity = Vector3.zero;
    }

    public void OnUpdate(PlayerController controller)
    {
        controller.Attack();
        if (controller.c_Attack == null || !controller.DistanceToAttack())
        {
            controller.ChangeState(new IPlayerIdleState());
        }
    }

    public void OnExit(PlayerController controller)
    {

    }
}
