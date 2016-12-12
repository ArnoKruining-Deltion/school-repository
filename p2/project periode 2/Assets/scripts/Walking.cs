using UnityEngine;
using System.Collections;

public class Walking : MonoBehaviour {
    public Vector3 a;
    public float hor;
    public float ver;
    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        a.x = hor;
        a.z = ver;

        transform.Translate(a*Time.deltaTime*speed);
	}
}
