using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Ordenar los numeros pares del 0 al 100
    void Start()
    {
        for (int i = 0; i <= 100; i += 2)
        {
            //mostrar en consola

            Debug.Log("Los numeros pares del 0 al 100 son: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
