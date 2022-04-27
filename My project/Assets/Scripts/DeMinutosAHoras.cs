using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeMinutosAHoras : MonoBehaviour
{
    public float IngreseMinutos;
    private float Operacion1;
    private float Operacion2;
    // Start is called before the first frame update
    void Start()
    {
        Operacion1 = (IngreseMinutos) / 60;
        Operacion2 = (Operacion1)%60f;
        Debug.Log("Los minutos a horas son: " + Operacion1 + " horas " + Operacion2 + " minutos ");
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
