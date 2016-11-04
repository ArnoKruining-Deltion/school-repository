using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestScript3 : MonoBehaviour {
  
   
   
   // public int score;
   // public Text scoreVeld;
    public Rigidbody red;

   


    // Use this for initialization
    void Start () {
        

    }
	
	//Update is called once per frame
	
    void OnCollissionEnter()
    {
        //score = score + 10;
       // scoreVeld.text = score.ToString();
        red.AddForce(0, 0, 1000,ForceMode.Impulse);
        

    }
}
