using UnityEngine;
using System.Collections;

public class Inetraction : MonoBehaviour {
    private RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Physics.Raycast(transform.position,transform.forward,out hit,100f))
        {
            if (hit.transform.tag == "ScoreHolder")
            {
             Destroy(hit.collider.gameObject);
                print("hit");
            }

        }
        
	}
}
