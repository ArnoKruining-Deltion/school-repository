using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	public void OnCollisionEnter(Collision c)
    {
        print("hoi");
        Destroy(c.gameObject);
        GameObject.Find("manager").GetComponent<GameManager>().life = -1;
    }
}
