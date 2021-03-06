using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Persona : PlayableCharacter
{
    protected int velocidadMovimiento; //protected significa que solo pueden acceder a ella los hijos
    public static List<string> listaNombres = new List<string>(){ " Hanzo", " Genji", " Torbjron", " Zennyata", " Mei", " Phara", " Briggite", " Ana", " Moira", " Lucio", " Reaper", " Phara", " Sombra", " Dva", " Junkrat"};
     
    //el static para que los objetos pueden acceder a ella y no se repita por cada objeto al instanciarlo (generarlo), si no que está aquí(en la clase) guardada nada más.
    public string MovimientoTierra(){
        Debug.Log("Me estoy moviendo a " + velocidadMovimiento);
        return "Me estoy moviendo a " + velocidadMovimiento;
    }
    
}
