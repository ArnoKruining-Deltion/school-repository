using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestScript3 : MonoBehaviour {
  
 
  
    public int score;
    public Text scoreVeld;
    public Rigidbody rad;
   


    
    void OnTriggerEnter(Collider collision)
    {
        score = score + 10;
        scoreVeld.text = score.ToString();
        rad.AddForce(0, 0, 100, ForceMode.Impulse);
    }
}
