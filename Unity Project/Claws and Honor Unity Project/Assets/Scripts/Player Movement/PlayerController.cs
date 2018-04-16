using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

    public LayerMask movementMask;
    Camera cam;
    PlayerMotor motor;
    Jump jump;
    
    // Use this for initialization
	void Start () {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
        jump = GetComponent<Jump>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
