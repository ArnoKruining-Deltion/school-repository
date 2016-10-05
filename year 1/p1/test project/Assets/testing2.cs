using UnityEngine;
using System.Collections;

public class testing2 : MonoBehaviour {


    int teller = 0;
    string klaar = "klaar";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(teller < 500)
        {
            teller++;
            print(teller);  
        }
        else if (teller == 500)

        {
            teller++;
            print(klaar);
        
        }
        
	}
}
