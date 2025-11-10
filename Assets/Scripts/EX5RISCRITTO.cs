using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX5RISCRITTO : MonoBehaviour
{
    public enum STATE
    {
        IDLE,
        AGGROED,
        ATTACKING,
        DEFEATED
    }

    [SerializeField] private STATE currentState = STATE.IDLE;
    void Start()
    {
        
    }

    void Update()
    {
        switch (currentState)
        {
            case STATE.IDLE:
                Debug.Log("Il nemico è fermo.");
                break;
            case STATE.AGGROED:
                Debug.Log("Il nemico insegue il giocatore.");
                break;
            case STATE.ATTACKING:
                Debug.Log("Il nemico sta attaccando il giocatore.");
                break;
            case STATE.DEFEATED:
                Debug.Log("Il nemico è sconfitto.");
                break;
            default:
                Debug.LogWarning("Stato sconosciuto!");
                break;
        }
    }
}
