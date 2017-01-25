using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enem : MonoBehaviour {
    public enum State
    {
        Een,
        Twee,
        Drie
    }
    public State state;
    public Vector3 v;
	
    
	void Start () {
        state = State.Een;
	}
	
	
	void Update () {
        if (state == State.Een)
        {
            v.y = 1;
           transform.position = v;

        }
        if (state == State.Twee)
        {
            v.y = 5;
            transform.position = v;

        }
        if (state == State.Drie)
        {
            transform.Translate(0, Time.deltaTime, 0);
            
            
            v.y = 10;
            transform.position = v;

        }
    }   
}
