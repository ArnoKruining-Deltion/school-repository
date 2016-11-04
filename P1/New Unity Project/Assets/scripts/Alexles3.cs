using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Alexles3 : MonoBehaviour {

    public Button knop;
    public Text tekst;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Clicked()
    {
        tekst.text = " clicked";
    }
}
