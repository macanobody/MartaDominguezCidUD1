using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    [SerializeField]
    // Cambia este numero desde el Inspector
    private int MonthNumber = 1;
    private string MonthName = "";

    // Start is called before the first frame update
    void Start()
    {
        // Condicion multiple, segun el numero es el nombre del mes

        switch (MonthNumber)
        {
            case 1: MonthName = "Enero"; break;
            case 2: MonthName = "Febrero"; break;
            case 3: MonthName = "Marzo"; break;
            case 4: MonthName = "Abril"; break;
            case 5: MonthName = "Mayo"; break;
            case 6: MonthName = "Junio"; break;
            case 7: MonthName = "Julio"; break;
            case 8: MonthName = "Agosto"; break;
            case 9: MonthName = "Septiembre"; break;
            case 10: MonthName = "Octubre"; break;
            case 11: MonthName = "Noviembre"; break;
            case 12: MonthName = "Diciembre"; break;
            default: MonthName = "N?mero inv?lido"; break;
        }

        // Mostrar resultado en la consola
        Debug.Log("El mes es: " + MonthName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
