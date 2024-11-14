using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyState
{
    public void OnStart(EnemyController controller);
    public void OnUpdate(EnemyController controller);
    public void OnExit(EnemyController controller);
}
