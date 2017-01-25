using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {
    public List<GameObject> objects = new List<GameObject>( );
    public List<GameObject> spawnedObjects= new List<GameObject>();
    public int random;       

	// Use this for initialization
	void Start () {
        
       
        for(int i = 0; i < 10; i++)
        {

            random = Random.Range(0, objects.Count);
            spawnedObjects.Add((GameObject)Instantiate(objects[i], Vector3.zero, Quaternion.identity));

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
