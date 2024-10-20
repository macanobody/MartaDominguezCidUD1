using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    // Ordenar los numero impares del 1 al 100
    void Start()
    {
        for (int i = 1; i < 100; i += 2)
        {
            //mostrar en consola
            Debug.Log("Los numeros impares del 1 al 100 son: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
