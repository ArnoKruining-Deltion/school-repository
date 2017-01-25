using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager manager;
	// Use this for initialization
	void Start () {
        print(Test2.StatFloat);
        DontDestroyOnLoad(gameObject);
        if (manager == null)
        {
            manager = this; 
           
        }
	     else if(manager != this)
            {
                Destroy(gameObject);
            }
	}
	// Update is called once per frame
	void Update () {
		
	}
}
