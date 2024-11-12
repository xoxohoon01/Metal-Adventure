using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerState
{
    public void OnStart(PlayerController controller);
    public void OnUpdate(PlayerController controller);
    public void OnExit(PlayerController controller);
}
