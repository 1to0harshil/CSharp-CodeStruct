using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;
/*
 Add State Class According to You */
class Player : StateManager<playerState> {

    private void Awake() {
        // Initialize your player states here.
        states.Add(playerState.idle, new IdleState());
        // states.Add(playerState.walk, new WalkState());
        //  states.Add(playerState.running, new RunState());
        //  states.Add(playerState.jump, new JumpState());
        //  states.Add(playerState.crouch, new CrouchState());
        //  states.Add(playerState.attacking, new AttackState());
        //  states.Add(playerState.gettingHit, new GettingHitState());
        //  states.Add(playerState.Reviving, new ReviveState());
        //  states.Add(playerState.Aiming, new AimState());
        //  states.Add(playerState.hiding, new HideState());
        //  states.Add(playerState.dead, new DeadState());

        // Set the initial state (e.g., 'idle') here.
        currentState = states[playerState.idle];
        currentState.EnterState();
    }

}



