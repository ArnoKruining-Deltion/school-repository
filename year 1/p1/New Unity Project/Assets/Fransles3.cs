using UnityEngine;
using System.Collections;

public class Fransles3 : MonoBehaviour {
    public Vector3 move;
    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Vector3 dir = move * speed * Time.deltaTime;

        //transform.Translate(dir);
        if (Input.GetButton("Jump"))
        {
            Vector3 dir = move * speed * Time.deltaTime;

            transform.Translate(dir);
            print("hoi");
        }

        
	}
}
