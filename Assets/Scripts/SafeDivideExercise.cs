using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeDivideExercise : MonoBehaviour
{
    [SerializeField] private int dividendo = 10;
    [SerializeField] private int divisore = 2;
     public bool SafeDivide( int dividendo, int divisore, out int risultato)
    {
        if (divisore == 0)
        {
            risultato = 0;
            return false;
        }
        else
        {
            risultato = dividendo / divisore;
            return true;
        }
    }
    void Start()
    {
        int risultato;
        bool DivisioneRiuscita = SafeDivide(dividendo, divisore, out risultato);

        // controllo il valore booleano di ritorno
        if (DivisioneRiuscita)
        {
            Debug.Log("Divisione eseguita correttamente. Risultato = " + risultato);
        }
        else
        {
            Debug.LogWarning("Impossibile dividere: il divisore non può essere zero.");
        }

    }

   
    void Update()
    {
        
    }
}
