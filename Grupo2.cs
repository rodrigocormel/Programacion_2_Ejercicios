using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grupo2 : MonoBehaviour
{
    void start()
    {
        numero1();
        numero2();
        numero3();
        numero4();

    }

    void numero1()
    {
        int x = Random.range(0, 10);
    
        if (x % 2 == 0)
        {
            Debug.Log("Par");
        }
        else
        {
        Debug.Log("Impar");
        }
    }

    void numero2()
    {
        int mes;
        mes = random.range(1, 12);
        switch(mes)
        {
            case 1:
                Debug.Log("Enero");
                break;
            case 2:
                Debug.Log("Febrero");
                break;
            case 3:
                Debug.Log("Marzo");
                break;
            case 4:
                Debug.Log("Abril");
                break;
            case 5:
                Debug.Log("Mayo");
                break;
            case 6:
                Debug.Log("Junio");
                break;
            case 7:
                Debug.Log("Julio");
                break;
            case 8:
                Debug.Log("Agosto");
                break;
            case 9:
                Debug.Log("Septiembre");
                break;
            case 10:
                Debug.Log("Octubre");
                break;
            case 11:
                Debug.Log("Noviembre");
                break;
            case 12:
                Debug.Log("Diciembre");
                break;
        }
    }
}
