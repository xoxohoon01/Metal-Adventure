using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPlayerMoveState : IPlayerState
{
    public void OnStart(PlayerController controller)
    {

    }

    public void OnUpdate(PlayerController controller)
    {
        if (!controller.FindTarget())
        {
            controller.ChangeState(new IPlayerIdleState());
        }
        if (controller.DistanceToAttack())
        {
            controller.ChangeState(new IPlayerAttackState());
        }
        controller.rb.velocity = (controller.target.transform.position - controller.transform.position).normalized * controller.player.MoveSpeed.curValue;
    }

    public void OnExit(PlayerController controller)
    {

    }
}
