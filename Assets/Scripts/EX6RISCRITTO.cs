using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX6RISCRITTO : MonoBehaviour
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

        switch (attackType)
        {
            case DAMAGE_TYPE.SLASHING:
            case DAMAGE_TYPE.PIERCING:
            case DAMAGE_TYPE.BLUDGEONING:
            case DAMAGE_TYPE.MAGICAL:
            case DAMAGE_TYPE.FORCE:
                if (attackType == resistance)
                {
                    baseDamage /= 2;
                    Debug.Log("Il nemico è resistente a questo attacco! Danno ridotto a: " + baseDamage);
                }
                break;
        }
        switch (attackType)
        {
            case DAMAGE_TYPE.SLASHING:
            case DAMAGE_TYPE.PIERCING:
            case DAMAGE_TYPE.BLUDGEONING:
            case DAMAGE_TYPE.MAGICAL:
            case DAMAGE_TYPE.FORCE:
                if (attackType == weakness)
                {
                    baseDamage *= 2;
                    Debug.Log("Il nemico è debole a questo attacco! Danno aumentato a: " + baseDamage);
                }
                break;
        }

        Debug.Log("Valore finale del danno: " + baseDamage);

    }
}
