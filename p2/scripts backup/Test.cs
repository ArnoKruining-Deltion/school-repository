using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
    public int number;
    public float l;
    
	// Use this for initialization
	void Start () {
        TestVoid(8,12.2f);
        
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    // de variable die je daarboven hebt gedeclareert tel je i bij op 
    void TestVoid(int i, float f )
    {
        number += i;
        l += f;
        
    }
}
