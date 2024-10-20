using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class LimitedIntArray
{
    [SerializeField]

    // Solo permite hasta 3 números
    private int[] numbers = new int[3]; 

    public int[] Numbers => numbers;
}

public class FromLargestToSmallest : MonoBehaviour
{
    [SerializeField]

    // Cambiar los números desde el Inspector

    private LimitedIntArray LimitedNumbers; 

    void Start()
    {
        // Ordenar los números de mayor a menor
        
        System.Array.Sort(LimitedNumbers.Numbers);

        // Invertir el orden después de la ordenación

        System.Array.Reverse(LimitedNumbers.Numbers); 

        // Mostrar los números ordenados en la consola
        Debug.Log("Números de mayor a menor: " + string.Join(", ", LimitedNumbers.Numbers));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
