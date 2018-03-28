using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Camera cam;
    
    // Use this for initialization
	void Start () {
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
               RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log("We hit" + hit.collider.name + " " + hit.point);
                //Move our player to what we hit

                //Stop focusing any objects
            }
        }
	}
}
