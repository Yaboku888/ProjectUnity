using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromedioExamenFinal : MonoBehaviour
{
    public float nota1;
    public float nota2;
    public float nota3;
    public float TrabajoFinal;
    public float ExamenFinal;
    private float SumaNotas1;
    private float ExamenFFinal;
    private float TrabajoFFinal;
    private float promedioNota;
    private float ResultadoFinal;
    // Start is called before the first frame update
    void Start()
    {
        SumaNotas1 = (nota1 + nota2 + nota3 ) /3;
        promedioNota = SumaNotas1 * 0.55f;
        ExamenFFinal = ExamenFinal * 0.30f;
        TrabajoFFinal = TrabajoFinal * 0.15f;
        ResultadoFinal = (promedioNota + ExamenFFinal + TrabajoFFinal);

        Debug.Log(ResultadoFinal);
        
        if (ResultadoFinal >= 0f && ResultadoFinal <= 3.4f)
        {
            Debug.Log(  "El usuario Reprueba" );

        }

         if (ResultadoFinal >= 3.5f && ResultadoFinal <= 5.0f )
        {
            Debug.Log( "El usuario Aprobo" );


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
