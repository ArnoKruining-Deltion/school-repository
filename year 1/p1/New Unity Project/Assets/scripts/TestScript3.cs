using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestScript3 : MonoBehaviour {
  
    public bool x;
    public bool y;
    public bool z;
    public bool rx;
    public bool ry;
    public bool rz;
    public Vector3 test3;
    public int score;
    public Text scoreVeld;
    public Rigidbody red;

   


    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        transform.position = test3;

        if ( x == true)
        {
            test3.x += 0.1f;
        }
        if(y == true)
        {
            test3.y += 0.1f;
        }
        if(z == true)
        {
            test3.z += 0.1f;
        }
        if (rx == true)
        {
            test3.x -= 0.1f;
        }
        if (ry == true)
        {
            test3.y -= 0.1f;
        }
        if (rz == true)
        {
            test3.z -= 0.1f;
        }
        

    }
    void OnCollisionEnter()
    {
        score = score + 10;
        scoreVeld.text = score.ToString();
        red.AddForce(0, 0, 1000,ForceMode.Impulse);
        

    }
}
