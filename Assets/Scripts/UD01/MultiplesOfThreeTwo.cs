using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    
    void Start()
    {
       //multiplos de 2
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                //mostrar en consola

                Debug.Log("Es multiplo de 2: " + i);
            }
        }

        //multiplos de 3

        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                //mostrar en consola

                Debug.Log("Es multiplo de 3: " + i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
