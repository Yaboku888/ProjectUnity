using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algoritmodesendiente : MonoBehaviour
{
    public int DigiteElnumeroADescender;
    private int i;
    // Start is called before the first frame update
    void Start()
    {

        i= DigiteElnumeroADescender;
        //     
        while (i >0)
        {
            Debug.Log(i);
            i = i - 1;
        }
        Debug.Log(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
