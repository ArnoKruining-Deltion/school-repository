using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public bool x;
    public bool y;
    public bool z;
    public bool rx;
    public bool ry;
    public bool rz;
    public Vector3 test3;
    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        transform.position = test3;

        if (x == true)
        {
            test3.x += 0.1f;
        }
        if (y == true)
        {
            test3.y += 0.1f;
        }
        if (z == true)
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
}
