using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class StateManager<Estate> : MonoBehaviour where Estate : Enum {
    protected Dictionary<Estate, BaseState<Estate>> states = new Dictionary<Estate, BaseState<Estate>>();
    protected BaseState<Estate> currentState;

    protected bool isTransitioningState = false;

    private void Start() {
        currentState.EnterState();
    }
    protected void Update() {
        Estate nextStartKey = currentState.GetNextState();

        if (!isTransitioningState && nextStartKey.Equals(currentState.Statekey)) {
            currentState.UpdateState();
        }
        else {
            TransitionToState(nextStartKey);
        }
    }

    private void TransitionToState(Estate stateKey) {
        isTransitioningState = true;
        currentState.ExitState();
        currentState = states[stateKey];
        currentState.EnterState();
        isTransitioningState = false;
    }
    private void OnTriggerEnter(Collider other) {

    }
    private void OnTriggerStay(Collider other) {

    }
    private void OnTriggerExit(Collider other) {

    }
}

