using UnityEngine;
using System.Collections;

public class ValueChanger : MonoBehaviour {
    public int score ;

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "ScoreHolder")
        {
            AddScore(c.gameObject.GetComponent<Value>().value);
        }
    }
    void AddScore(int i)
    {
        score += i;
    }
}
