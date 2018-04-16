using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour {
    public float turningSpeed = 150.0f;
    public float movementSpeed = 3.0f;


    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * turningSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

    }

}
