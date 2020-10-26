using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStateMachine : MonoBehaviour
{
    private EntityState currentState;

    private void Initialize(EntityState startingState) 
    {
        currentState = startingState;
        currentState.EnterState();
    }

    public void ChangeState(EntityState newState) 
    {
        currentState.ExitState();

        currentState = newState;
        currentState.EnterState();
    }
}
