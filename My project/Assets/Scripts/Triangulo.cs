using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo : MonoBehaviour
{
    public int Catetob;
    public int Catetoc;
    private float Operacion1;
    // Start is called before the first frame update
    void Start()
    {
        
        Operacion1 = Mathf.Sqrt (Catetob * Catetob) + (Catetoc * Catetoc);
        Debug.Log("La hipotenusa del triangulo es: " + Operacion1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
