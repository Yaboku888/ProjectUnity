using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasaCorporal : MonoBehaviour
{
    public string NombreDeUsuario;
    public float AlturaEnCentimetros;
    public float PesoEnKilogramo;
    private float multiplicacion;
    private float division;



    // Start is called before the first frame update
    void Start()
    {
    
        multiplicacion = (AlturaEnCentimetros * AlturaEnCentimetros);
        division = (PesoEnKilogramo / multiplicacion);
        Debug.Log(division);
        
        if (division <18.5)
        {
            Debug.Log(" Usuario " + NombreDeUsuario + " Tas bien Seco ");
        }
        if (division >=18.5)
        {
            Debug.Log("MASA NORMAL PAPU");

        }
        if (division >=25-0)
        {
            Debug.Log("estas algo pasado de masa");

        }
        if (division >=29.9)
        {
            Debug.Log("Tas bien gordo");
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
