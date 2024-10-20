using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
// selecciona 3 números desde el Inspector
{
    [SerializeField]
    private int[] numbers = new int[3]; 

   
    void Start()
    {
        //Tres números introducidos
        if (numbers.Length == 3)
        {
            bool isIncreasing = (numbers[0] < numbers[1]) && (numbers[1] < numbers[2]);

            // Mostrar en consola
            Debug.Log("¿Están en orden creciente? " + isIncreasing);
        }
        else
        {
            //mostrar en consola
            Debug.Log("Por favor, introduce exactamente 3 números.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
