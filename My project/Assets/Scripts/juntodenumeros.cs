using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juntodenumeros : MonoBehaviour
{
    private int cont, resultado;
    public int DigitosQuedeseaAllar;
    // Start is called before the first frame update
    void Start()
    {
        cont = 0;
         resultado = 0; 
       while  (cont<=DigitosQuedeseaAllar)
        {
            resultado = (resultado + cont);
                cont = cont + 2;





        }
        Debug.Log(resultado);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
