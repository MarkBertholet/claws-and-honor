using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour {

    const float locomotionAnimationSmoothTime = .1f;

    NavMeshAgent agent;
    Animator animator;

    void Start ()  {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update () {
        float SpeedPercent = agent.velocity.magnitude / agent.speed;
        animator.SetFloat("SpeedPercent", SpeedPercent, locomotionAnimationSmoothTime, Time.deltaTime);
    }
}



