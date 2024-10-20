using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Cambiar los números

        int[] numbers = { 3, 2, 1 }; 
        bool isDescending = (numbers[0] > numbers[1]) && (numbers[1] > numbers[2]);

        //mostrar en consola

        Debug.Log("¿Están en orden decreciente? " + isDescending);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
