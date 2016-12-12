using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
    public Vector3 speed;
    public Rigidbody r;
    public bool jumptrue = true;
    public int power = 3;
	// Use this for initialization
	void Start () {
	
	}
    void OnCollisionEnter()
    {
        jumptrue = true;
    }
	
	// Update is called once per frame
	void Update () {

       

        if (power > 0)
        {
            if (jumptrue == true)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    power -= 1;
                    r.velocity = speed;
                             if (power == 0)
                             {
                                 jumptrue = false;
                                 power = 3;
                             }
                }
            }
        }
	}
}
