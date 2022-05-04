using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoDeSillas : MonoBehaviour
{
    [Header("de cada tipo de madera: ")]
    [Header("Escriba la cantidad de sillas...")]


    public float CantidadDeSillas;
    public bool MaderaA;
    private float TipoA;
    private float operacion;
    /*7. Un comerciante se dedica a la venta de sillas únicamente. Vende tres tipos de sillas:
    tipo A, tipo B y Tipo C los precios son $5.00, $7.00 y $10.00 respectivamente. Por cada
    cinco sillas compradas del tipo A, del tipo B o del tipo C los clientes reciben un
    descuento de 3%, 5% y 7%, las demás se cobran a precio normal. Diseñe un programa
    que imprima en forma de factura, con el nombre, precio unitario, precio total, nombre de
    la tienda, etc lo que debe cancelar cada cliente en concepto de la compra.*/
    // Start is called before the first frame update
    void Start()
    {
        TipoA = 5.00f;

        if (MaderaA == true )
        {
            if(CantidadDeSillas >=5)
            {
                
                operacion = (5.00f * CantidadDeSillas)* 0.97f;
                Debug.Log("Elegiste tipo de madera A, el descuento es del 3%: " +operacion);
            }
            else  if ( CantidadDeSillas<=5)
            {
                Debug.Log("Te toca pagar  " + TipoA + " Dolares ");
            }
        }



        if (MaderaA ==false)
        {
            Debug.Log("No me compraste la Madera A, Todo bien ");
        }
        
        
       
       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
