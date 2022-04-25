using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public string MyName;
    public string Friend;
    public int yearsOld1;
    public int yearsOld2;
    private int suma;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(MyName);
        Debug.Log(Friend);
        suma = yearsOld1 + yearsOld2;
        Debug.Log(suma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void correr()
    { 
    
    }
}
