using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IdleState : IState
{

    private AIcontroller aicontroller;
    private float idleDuraturation = 2f;
    private StateType Type => StateType.Idle;

    public IdleState(AIcontroller aiController)
    {
        this.aicontroller = aiController;
    }

    public void Enter()
    {
        idleTimer = 0f;
    }

    public void Execute()
    {
        idleTimer += Time.deltaTime;
        if (idleTimer >= idleDuraturation)
        {
            aicontroller.StateMachhine.TransitionToState(StateType.Patrol);
        }
    }

    public void Exit()
    {

    }
}
