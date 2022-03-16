using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arquero : Militar
{
    
    public Arquero(string n, int puntosAtaque){ //constructor
        Nacer();
        velocidadMovimiento = 50;
        nombre = n; 
        vidaTotal = 100;
        vidaActual = vidaTotal;
        attackPower = puntosAtaque;
        Debug.Log("Creado arquero" + nombre);
    }

}