using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallarElFactorial : MonoBehaviour
{
    public int DigiteElvalorDeN;
    private int Resultado = 1; 
    // Start is called before the first frame update
    void Start()
    {
        int i = 1;
        while (i <= DigiteElvalorDeN)
        {
            Resultado = (Resultado * i);
            i++;

        }
        Debug.Log("El factorial de " + DigiteElvalorDeN + "es: " + Resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
