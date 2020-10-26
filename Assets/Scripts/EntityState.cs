using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityState : MonoBehaviour
{
    protected EntityBase entity;
    protected EntityStateMachine stateMachine;


    public virtual void EnterState() 
    { 
    
    }

    public virtual void ExitState() 
    { 
    
    }

    public virtual void UpdateState() 
    { 
        
    }
}
