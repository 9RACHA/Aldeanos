using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero : Militar
{
    public Guerrero(string n, int puntosAtaque){ //constructor
        Nacer();
        velocidadMovimiento = 50;
        nombre = n; 
        vidaTotal = 100;
        vidaActual = vidaTotal;
        attackPower = puntosAtaque;
        Debug.Log("Creado guerrero " + nombre);
    }

}
