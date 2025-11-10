using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwitchBehaviour : MonoBehaviour
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
        if (currentState == STATE.IDLE)
        {
            Debug.Log("Il nemico è fermo.");
        }
        else if (currentState == STATE.AGGROED)
        {
            Debug.Log("Il nemico insegue il giocatore.");
        }
        else if (currentState == STATE.ATTACKING)
        {
            Debug.Log("Il nemico sta attaccando il giocatore.");
        }
        else if (currentState == STATE.DEFEATED)
        {
            Debug.Log("Il nemico è sconfitto.");
        }
    }
}
