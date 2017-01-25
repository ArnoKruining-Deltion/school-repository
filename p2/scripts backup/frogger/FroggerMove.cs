using UnityEngine;
using System.Collections;

public class FroggerMove : MonoBehaviour {
    public Vector3 ver;
    public Vector3 left;
    public Vector3 right;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Forward"))
        {

            transform.position += ver;
           
        }
        if (Input.GetButtonDown("Left"))
        {

            transform.position += left;

        }
        if (Input.GetButtonDown("Right"))
        {

            transform.position += right;

        }
    }
}//(ver*Time.deltaTime)
