using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificios : PlayableCharacter
{
    private tipoEdificio tipo;

     public Edificios(string e){ //constructor
        Nacer(); 
        vidaTotal = 100;
        vidaActual = vidaTotal;
        Debug.Log("Creado edificio ");
    }
    
}
//poner los enumerados fuera de la clase para que todas las clases puedan usarlos
public enum tipoEdificio { 
        Granja,
        Casa,
        Cuartel,
        Iglesia,
        Castillo
    }