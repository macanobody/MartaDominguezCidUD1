using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    //cambiar el numero desde el inspector
    [SerializeField]
    private int inputNumber = 10;

    //suma de los numero +1
    void Start()
    {
        int sum = 0;

        for (int i = 1; i <= inputNumber; i++)
        {
            sum += i;
        }
        // mostrar en la consola
        Debug.Log("La suma de los números del 1 al " + inputNumber + " es: " + sum);
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
