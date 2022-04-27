using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    public int Base;
    public int Altura;
    private int operacion;
    private int operacion2;
   
    // Start is called before the first frame update
    void Start()
    {
        operacion = (Altura + Altura) + (Base + Base);
        Debug.Log("El perimetro del rectangulo es: " + operacion);

        operacion2 = (Altura * Base);
        Debug.Log("El area del reactangulo es: " + operacion2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
