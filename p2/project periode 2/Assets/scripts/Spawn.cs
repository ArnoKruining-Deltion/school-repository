using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    public GameObject g;
    public Vector3 v3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
       Instantiate(g, v3,Quaternion.identity);
	}
    
}
