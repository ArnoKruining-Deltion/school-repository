using UnityEngine;
using System.Collections;

public class FlipperMovment : MonoBehaviour {
    public float flipperStrength;
    public float pushForce;
    private HingeJoint hinge;


    void Start() {
        hinge = GetComponent<HingeJoint>();
    }


    void Update() {

    }
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 f = transform.up * flipperStrength;
            Vector3 p = (transform.right) + transform.position * pushForce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p);
        }
    }
}
