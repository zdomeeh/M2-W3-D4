using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    public enum DAMAGE_TYPE
    {
        SLASHING,
        PIERCING,
        BLUDGEONING,
        MAGICAL,
        FORCE
    }

    [SerializeField] private DAMAGE_TYPE attackType;
    [SerializeField] private DAMAGE_TYPE resistance;
    [SerializeField] private DAMAGE_TYPE weakness;
    [SerializeField] private int baseDamage = 10;
    void Start()
    {
        Debug.Log("Valore iniziale del danno: " + baseDamage);

        if (attackType == resistance)
        {
            baseDamage /= 2; 
            Debug.Log("Il nemico è resistente a questo attacco! Danno ridotto a: " + baseDamage);
        }

        if (attackType == weakness)
        {
            baseDamage *= 2;
            Debug.Log("Il nemico è debole a questo attacco! Danno aumentato a: " + baseDamage);
        }

        Debug.Log("Valore finale del danno: " + baseDamage);
    }

    void Update()
    {
        
    }
}
