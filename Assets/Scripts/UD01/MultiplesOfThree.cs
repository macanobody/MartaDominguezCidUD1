using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    
    void Start()
    {
            //calcular los multiplos de 3

        for (int i = 0; i <= 100; i += 3)
        {
            //mostrar en la consola

            Debug.Log("Los multiplos de 3 son: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
