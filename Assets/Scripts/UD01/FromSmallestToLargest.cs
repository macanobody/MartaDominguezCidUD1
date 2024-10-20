using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class FromSmallestToLargest : MonoBehaviour
{
    // Cambia los números desde el Inspector limitado a 3 numeros
    [SerializeField]
    private LimitedIntArray limitedNumbers; 

    
    void Start()
    {
        // Ordenar los números de menor a mayor
        System.Array.Sort(limitedNumbers.Numbers); 

        // Mostrar los números ordenados en la consola
        Debug.Log("Números de menor a mayor: " + string.Join(", ", limitedNumbers.Numbers)); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
