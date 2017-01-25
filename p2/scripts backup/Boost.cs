using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour {
    public int power;
    public Rigidbody rad;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            rad.AddRelativeForce(Vector3.left * power);

        }
    }
}
