using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grupo2 : MonoBehaviour
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
