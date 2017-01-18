using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
    public int size;
    public List<
        int> grid = new List<int>() ;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < size*size; i++)
        {
            grid.Add(0);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
