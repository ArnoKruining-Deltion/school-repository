using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour {
    public List<
        bool> b = new List<bool>();

	// Use this for initialization
	void Start () {
        for(int i = 0; i < 10; i++)
        {
            if (b[i] == true)
                {
                    print("true");
                }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
