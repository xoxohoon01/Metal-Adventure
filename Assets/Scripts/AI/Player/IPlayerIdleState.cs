using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPlayerIdleState : IPlayerState
{
    public void OnStart(PlayerController controller)
    {
        controller.rb.velocity = Vector3.zero;
    }

    public void OnUpdate(PlayerController controller)
    {
        if (controller.FindTarget())
        {
            controller.ChangeState(new IPlayerMoveState());
        }
    }

    public void OnExit(PlayerController controller)
    {

    }
}
