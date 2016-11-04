using UnityEngine;
using System.Collections;

public class Bananaman : MonoBehaviour {
    public int test;
    public float test2;
    public bool test3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        PlusEen();
        PlusPuntEen();
        print(test3);
        Switch();
	}
    void PlusEen()
    {
        test++;
        

    }
    void PlusPuntEen()
    {
        test2 = test2 + 0.1f;

    }
    void Switch()
    {
        if (test == 500) {
            test3 = false;
        }
        else {
            test3 = true;
             
                }         

    }
}
