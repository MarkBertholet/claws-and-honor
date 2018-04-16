using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpStrength = 10.0f;
    private Rigidbody rg;
    public float test1 = 100.0f;
    public float test2 = 100.0f;
    public float test3 = 100.0f;

    // Use this for initialization
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    public float raycastLength = 1.0F;

    void Update()
    {
        if (Physics.Raycast(transform.position, -transform.up, raycastLength))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 atas = new Vector3(test1, test2, test3);
                rg.AddForce(atas * jumpStrength);
            }
        }
    }
}