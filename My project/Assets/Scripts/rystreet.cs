using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos: MonoBehaviour
{
   public float VidaMaxima = 100;
    public float damage = 20;
    public float vidaactual;
    public void MakeDamega()
    {
        vidaactual = vidaactual - damage;
    }
    // Start is called before the first frame update
    void Start()
    {
        vidaactual = VidaMaxima; 
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
