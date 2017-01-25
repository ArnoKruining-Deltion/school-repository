using UnityEngine;
using System.Collections;

public class LiveLoss : MonoBehaviour {
    public int life ;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Danger")
            {
                life = life - 1;
                print(life);
    
            }
  }
}
