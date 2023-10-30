using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class BaseState<Estate> : MonoBehaviour where Estate : Enum {
    public BaseState(Estate estate) {
        Statekey = estate;
    }
    public Estate Statekey {get; private set;}
    public abstract void EnterState();
    public abstract void ExitState();
    public abstract void UpdateState();
    public abstract Estate GetNextState();
    public abstract void OntriggerEnter(Collider other);
    public abstract void OntriggerStay(Collider other);
    public abstract void OntriggerExit(Collider other);
    
}
