using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableSwap : MonoBehaviour
{
    public void Swap(int n, int m)
    {
        int change = n;
        n = m;
        m = change;
        Debug.Log("VALORI DENTRO LA PRIMA FUNZIONE SWAP: N = " + n + " M = " + m);
    }

    public void Swap(ref int n, ref int m)
    {
        int change = n;
        n = m;
        m = change;
        Debug.Log("VALORI DENTRO LA SECONDA FUNZIONE SWAP: N = " + n + "  M = " + m);
    }
    void Start()
    { 
        int a= 5;
        int b= 10;
        Debug.Log("VALORI PRIMA DELLO SCAMBIO: A = " + a + " B = " + b);

        int change = a;
        a = b;
        b = change;
        Debug.Log("VALORI DOPO LO SCAMBIO: A = " + a + " B = " + b);

        Swap(a, b);
        Debug.Log("VALORI DOPO LA PRIMA FUNZIONE SWAP: A = " + a + " B = " + b);

        Swap(ref a, ref b);
        Debug.Log("VALORI DOPO LA SECONDA FUNZIONE SWAP: A = " + a + " B = " + b);
    }

    // NEL PRIMO CASO "Swap(int n, int m)"
    // - Le variabili vengono passate per valore.
    // - Significa che la funzione riceve SOLO UNA COPIA dei valori di A e B.
    // - Quando scambio n e m dentro la funzione, scambio solo le copie,
    //   non le variabili originali dichiarate nello Start().
    // - Per questo, al ritorno dalla funzione, A e B restano invariati.
    //
    // NEL SECONDO CASO "Swap(ref int n, ref int m)"
    // - Le variabili vengono passate per riferimento.
    // - La funzione riceve un riferimento diretto alle variabili originali A e B.
    // - Scambiando n e m dentro la funzione, sto modificando direttamente A e B.
    // - Per questo motivo, dopo la chiamata, i valori di A e B risultano effettivamente invertiti.

    void Update()
    {
        
    }
}
