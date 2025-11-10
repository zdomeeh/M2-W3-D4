using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetsPlayWithArrays : MonoBehaviour
{
    [SerializeField] private int[] array = { 2, 4, 6, 8, 10 };
    
    void Start()
    {
        Debug.Log("Array iniziale: " + ArrayToString(array));

        int valueToFind = 6;
        int index = Find(array, valueToFind);
        Debug.Log("Primo indice di " + valueToFind + " = " + index);

        PutToTheBack(array, 1); 
        Debug.Log("Array dopo PutToTheBack(1): " + ArrayToString(array));

        ShiftOnce(array);
        Debug.Log("Array dopo ShiftOnce: " + ArrayToString(array));

        Shift(array, 3);
        Debug.Log("Array dopo Shift(3): " + ArrayToString(array));
    }

    int Find(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                return i;
            }
        }
        return -1;
    }

    
    void PutToTheBack(int[] array, int index)
    {
        if (index < 0 || index >= array.Length) return; 

        int temp = array[index];

        
        for (int i = index; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        
        array[array.Length - 1] = temp;
    }

  
    void ShiftOnce(int[] array)
    {
        if (array.Length == 0) return;

        int last = array[array.Length - 1];

        
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }

        
        array[0] = last;
    }

   
    void Shift(int[] array, int times)
    {
        int n = array.Length;
        if (n == 0) return;

        times = times % n; 
        if (times == 0) return;

        
        int[] temp = new int[n];
        for (int i = 0; i < n; i++)
        {
            temp[(i + times) % n] = array[i];
        }

        
        for (int i = 0; i < n; i++)
        {
            array[i] = temp[i];
        }
    }

    string ArrayToString(int[] array)
    {
        string s = "[ ";
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i] + " ";
        }
        s += "]";
        return s;
    }
    void Update()
    {
        
    }
}
