using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem.XR;

[RequireComponent(typeof(Enemy))]
public class EnemyController : MonoBehaviour
{
    public Enemy enemy { get; private set; }
    public Rigidbody rb { get; private set; }
    public GameObject target { get; private set; }

    IEnemyState currentState;

    private bool canAttack = true;
    IEnumerator Attack(float time)
    {
        canAttack = false;
        target.GetComponent<Unit>().TakeDamage(enemy.Damage.curValue);
        yield return new WaitForSeconds(time);
        canAttack = true;
    }
    public Coroutine c_Attack { get; private set; }

    public bool FindTarget()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 100f, LayerMask.GetMask("Player"));
        if (colliders.Length > 0)
        {
            target = colliders[0].gameObject;
            for (int i = 0; i < colliders.Length; i++)
            {
                if (Vector3.Distance(transform.position, target.transform.position) > Vector3.Distance(transform.position, colliders[i].transform.position))
                {
                    target = colliders[i].gameObject;
                }
            }
            return true;
        }
        else return false;
    }

    public bool DistanceToAttack()
    {
        if (target != null && Vector3.Distance(transform.position, target.transform.position) <= enemy.Range.GetValue())
            return true;
        else 
            return false;
    }

    public void Attack()
    {
        if (canAttack)
        {
            c_Attack = StartCoroutine(Attack(1.0f / enemy.AttackSpeed.curValue));
        }
    }

    public void ChangeState(IEnemyState newState)
    {
        currentState.OnExit(this);
        currentState = newState;
        currentState.OnStart(this);
    }

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        currentState = new IEnemyIdleState();
        currentState.OnStart(this);
    }

    private void Update()
    {
        currentState.OnUpdate(this);
    }
}
