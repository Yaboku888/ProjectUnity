using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    public float DigiteCodigo;
    public float Numero1;
    public float Numero2;
    private float operacionSuma;
    private float operacionResta;
    private float operacionMultiplicacion;
    private float operacionDivision;


    // Start is called before the first frame update
    void Start()
    {
        if (DigiteCodigo == 1)
        {
           operacionSuma = (Numero1 + Numero2);
            Debug.Log("Elegiste suma, el resultado es: " + operacionSuma);

        }
        if (DigiteCodigo ==2)
        {
            operacionResta = (Numero1 - Numero2);
            Debug.Log("Elegiste Resta, el resultado es: " + operacionResta);
        }
        if (DigiteCodigo==3)
        {
            operacionMultiplicacion = (Numero1 * Numero2);
            Debug.Log("Elegiste Multiplicacion, el resultado es: " + operacionMultiplicacion);
        }
        if (DigiteCodigo==4)
        {
            operacionDivision = (Numero1 / Numero2);
            Debug.Log("Elegiste Division, el resultado es: " + operacionDivision);
        }

        if (DigiteCodigo>=5)
        {
            Debug.Log("Codigo fuera de rango, invalido");
        }


        }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
