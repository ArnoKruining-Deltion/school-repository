using UnityEngine;
using System.Collections;

public class ThrowGrenade : MonoBehaviour {
    public GameObject grenade;
    public Vector3 spawnposition;
    public Rigidbody e;
    public Vector3 force;
    public Transform parent;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
           GameObject newball = (GameObject) Instantiate(grenade, parent.position, grenade.transform.rotation);
            newball.GetComponent<Rigidbody>().velocity = force;
        }



    }
}
