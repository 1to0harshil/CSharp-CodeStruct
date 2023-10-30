using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Player;

public class IdleState : BaseState<playerState> {
    public IdleState() : base(playerState.idle) {
    }

    public override void EnterState() {
        // Enter idle state logic
    }

    public override void UpdateState() {
        // Update idle state logic
    }

    public override playerState GetNextState() {
        // Calculate the next state based on conditions
        return playerState.walk; // Example transition to 'walk' state
    }

    public override void ExitState() {
        // Exit idle state logic
    }

    private void Update() {
        
    }

    public override void OntriggerEnter(Collider other) {
      
    }

    public override void OntriggerStay(Collider other) {
        //throw new NotImplementedException();
    }

    public override void OntriggerExit(Collider other) {
        //throw new NotImplementedException();
    }
}
