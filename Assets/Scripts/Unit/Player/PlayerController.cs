using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem.XR;

[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour
{
    public Player player;
    IPlayerState currentState;
    public Rigidbody rb;
    public GameObject target;

    private bool canAttack = true;
    IEnumerator Attack(float time)
    {
        canAttack = false;
        target.GetComponent<Unit>().TakeDamage(player.Damage.curValue);
        yield return new WaitForSeconds(time);
        canAttack = true;
    }
    public Coroutine c_Attack { get; private set; }


    public bool FindTarget()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 100f, LayerMask.GetMask("Enemy"));
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
        if (target != null && Vector3.Distance(transform.position, target.transform.position) <= player.Range.GetValue())
            return true;
        else 
            return false;
    }

    public void Attack()
    {
        if (canAttack)
        {
            c_Attack = StartCoroutine(Attack(1.0f / player.AttackSpeed.curValue));
        }
    }

    public void ChangeState(IPlayerState newState)
    {
        currentState.OnExit(this);
        currentState = newState;
        currentState.OnStart(this);
    }

    private void Awake()
    {
        player = GetComponent<Player>();
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        currentState = new IPlayerIdleState();
        currentState.OnStart(this);
    }

    private void Update()
    {
        currentState.OnUpdate(this);
    }
}
