using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootBall : MonoBehaviour {

   public Rigidbody rad;

	
    // Use this for initialization
	void Start () {
        rad.AddForce(0, 0, -10, ForceMode.Impulse);
	}
	
	

}
