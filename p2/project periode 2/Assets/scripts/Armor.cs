using UnityEngine;
using System.Collections;

public class Armor : MonoBehaviour {
    public float damage;
    public float armorpercentage = 0.8f;
    public float finalDamage;

    void Start()
    {
        finalDamage =  ArmorReduction(120);
        
    }

    float ArmorReduction (float i)
    {
        finalDamage *= damage;
        
        i *= armorpercentage;
        print(i);
       
        return i;
    }
	
	
}
