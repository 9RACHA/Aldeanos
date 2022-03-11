using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour

{  
    // = asignacion     == comparación
    //hay clases que no queremos instanciar o hacer objetos porque no tendría sentido, como no tendría sentido instanciar un objeto Persona
    //pero si un objecto Aldeano que deriba de este

    //necesitas un constructor para instanciar un objeto
    // una clase ABSTRACTA es una clase que no se puede instanciar (no se puede hacer objeto)

    // Start is called before the first frame update
    void Start()
    {
        
      /*Aldeano aldeano1 = new Aldeano(" n");
        aldeano1.Trabajar();
        aldeano1.MovimientoTierra();
        */

    // Ejercicio crear 10 aldeanos y ponerlos a trabajar

        /*List<Aldeano> listaAldeanos = new List<Aldeano>(); //se crea la lista para que no se borren los aldeanos que creemos

        for (int i = 0; i < 10; i++) {
            Aldeano aldeanoTemporal = new Aldeano();
            aldeanoTemporal.Trabajar(); 
            listaAldeanos.Add(aldeanoTemporal); //para que quede añadido en la lista

        
        }

        foreach (Aldeano aldeanoTemporal in listaAldeanos){ 
            aldeanoTemporal.Trabajar();         

        }
        */

       // Ejercicio crear 3 aldeanos y ponerles nombre
       
        /* List<Aldeano> listaAldeanos = new List<Aldeano>(); 
        
        for (int i = 0; i<3; i++) {
            string nombreAleatorio =  Persona.listaNombres[Random.Range(0, Persona.listaNombres.Count)];
            //Aldeano aldeanoTemporal = new Aldeano(Persona.listaNombres[i]); forma sucia para hacer que no se repitan los nombres
            Aldeano aldeanoTemporal = new Aldeano(nombreAleatorio);
            listaAldeanos.Add(aldeanoTemporal); //para que quede añadido en la lista
            
        }
        */

        // Ejercicio crear militar, aldeano y que el militar ataque al aldeano
        
       /* Militar verdugo = new Militar(" Namjoon");
        
        Aldeano victima = new Aldeano(" Jin");

        Debug.Log(victima.ToString());

        //int puntosAtaque = verdugo.Atacar();
        //victima.SerAtacado(puntosAtaque);
        for (int i = 0; i<11; i++){
            victima.SerAtacado(verdugo.Atacar());  
            if (! victima.getViva()) {
                victima = null;
                Debug.Log("Destruimos victima");
                break; //se sale del bucle para que no siga atacando a un obsjeto que ya está null
            }
        }
    

       // Ejercicio hacer método toString() para aldeano y militar que devuelvan un string con todos los atributos del objeto

       Debug.Log(victima.ToString());
       Debug.Log(verdugo.ToString()); 
    */

       //si pones un objeto = null es lo mismo que destruirlo solo se puede destruir una unidad en el main
       //Creamos las funciones de vivir y morir y destruímos el objeto si no está vivo 
       /*if (! victima.getViva()) {
           victima = null;
           Debug.Log("Destruimos victima");
       }*/

       // Ejercicio crear equipo rojo y equipo azul, con 1 aldeano (será el únco atacado) y 3 militares que atacan con 10, 20 y 30 respectivamente 
       // ataca un militar aleatoriamente cada vez. Primero ataca el equipo rojo y luego el azul.
       // Gana el primer equipo que consiga matar al aldeano del otro equipo.
       // Que ataquen los militares con 10, 20, 30(en el constructor le añadimos un int para ponerles los puntos de ataque)

      /* 
        List<Aldeano> AldeanosAzules = new List<Aldeano>(){new Aldeano(" Aldeano Azul") };

        List<Militar> MilitaresAzules = new List<Militar>(){new Militar(" Militar Azul 1", 10), new Militar(" Militar Azul 2", 20), new Militar(" Militar Azul 3", 30)};

        List<Aldeano> AldeanosRojos = new List<Aldeano>(); 

        AldeanosRojos.Add(new Aldeano("Aldeano Rojo"));

        List<Militar> MilitaresRojos = new List<Militar>();
       /* int puntosAtaqueTemporal = 10;
        for (int i=0; i<3; i++){
            MilitaresRojos.Add(new Militar(Persona.listaNombres[Random.Range(0, Persona.listaNombres.Count)], puntosAtaqueTemporal ));
            puntosAtaqueTemporal += 10;
        }
        */
        //Otra forma de hacerlo sería usando la i en vez de puntosAtaqueTemporal
        /*
        for (int i=0; i<3; i++){
            MilitaresRojos.Add(new Militar(Persona.listaNombres[Random.Range(0, Persona.listaNombres.Count)], (i + 1) * 10 )); // también valdría (1*10) +10
            
        }
        */
        
        //si sabemos el numero exacto de repeticiones o elementos usamos un for, si no sabemos el numero de veces que necesitamos repetir el bucle(en este caso atacar) usamos un bucle while
        // Que empiece a atacar inicialmente aleatoriamente uno de los dos equipos
        /* FORMA SUCIA
        int opcion = Random.Range(0, 2);//que la opcion sea 0 o 1 aleatoriamente (pq el 2 es exclusivo nunca va a salir)
        while (AldeanosAzules[0].getViva() && AldeanosRojos[0].getViva()){

            if(opcion==1){
                AldeanosAzules[0].SerAtacado(MilitaresRojos[Random.Range(0, 3)].Atacar());
                    if( ! AldeanosAzules[0].getViva()){
                        Debug.Log("Ganó el Rojo");
                        break;
                    }

                AldeanosRojos[0].SerAtacado(MilitaresAzules[Random.Range(0, 3)].Atacar());
                if( ! AldeanosRojos[0].getViva()){
                        Debug.Log("Ganó el Azul");
                        break; //este break no es necesario porque se comprueba si están vivos los aldeanos al principio del bucle 
                    }
            }

            else{
                
            AldeanosRojos[0].SerAtacado(MilitaresAzules[Random.Range(0, 3)].Atacar());
              if( ! AldeanosRojos[0].getViva()){
                    Debug.Log("Ganó el Azul");
                    break; 
                }
            AldeanosAzules[0].SerAtacado(MilitaresRojos[Random.Range(0, 3)].Atacar());
                if( ! AldeanosAzules[0].getViva()){
                    Debug.Log("Ganó el Rojo");
                    break;
                }
        
            }
        }
        
        /*int aleatorio = Random.Range(0,2);
        if (aleatorio == 0){
            AldeanosRojos[0].SerAtacado(MilitaresAzules[Random.Range(0, 3)].Atacar());
        }

        while (AldeanosAzules[0].getViva() && AldeanosRojos[0].getViva()){

           
                AldeanosAzules[0].SerAtacado(MilitaresRojos[Random.Range(0, 3)].Atacar());
                    if( ! AldeanosAzules[0].getViva()){
                        Debug.Log("Ganó el Rojo");
                        break;
                    }

                AldeanosRojos[0].SerAtacado(MilitaresAzules[Random.Range(0, 3)].Atacar());
                if( ! AldeanosRojos[0].getViva()){
                        Debug.Log("Ganó el Azul");
                        break; 
                    }
            
        //while, mientras lo de dentro del while se cumple, se sigue haciendo en bucle

        }
        */

        // EJERCICIO Que los militares ataquen a los aldeanos a través del método nuevo que creamos MilitarAtacaAldeano()
        // Hacer un booleano que devuelva true si está vivo y false si no
       /* int aleatorio = Random.Range(0,2);
        if (aleatorio == 0){
            MilitarAtacaAldeano(MilitaresAzules[Random.Range(0, 3)], AldeanosRojos[0]);
        }

        while (AldeanosAzules[0].getViva() && AldeanosRojos[0].getViva()){

           
            
            if( MilitarAtacaAldeano(MilitaresRojos[Random.Range(0, 3)], AldeanosAzules[0])){
                 Debug.Log("Ganó el Rojo");
                 break;
            }

                 
            if( MilitarAtacaAldeano(MilitaresAzules[Random.Range(0, 3)], AldeanosRojos[0])){
                 Debug.Log("Ganó el Azul");
                break; 
            }

        }
        */
    //Otra forma de que funcione (menos entendible)

      /*  int atacante = Random.Range(0,2);
        int defensor;
        if(atacante == 0){
            defensor = 1;
        }
        else{
            defensor = 0;
        }
        List<List<Aldeano>> aldeanos = new List<List<Aldeano>>();
        aldeanos.Add(AldeanosAzules);
        aldeanos.Add(AldeanosRojos);

        List<List<Militar>> militares = new List<List<Militar>>();
        militares.Add(MilitaresAzules);
        militares.Add(MilitaresRojos);
        

        while (AldeanosAzules[0].getViva() && AldeanosRojos[0].getViva()){

            if( MilitarAtacaAldeano(militares[atacante][Random.Range(0, 3)], aldeanos[defensor][0])){
                 Debug.Log("Ganó alguien");
                 break;
            }
            atacante = defensor;
            if(atacante == 0){
                defensor = 1;
            }
            else{
                defensor = 0;
            }

        }
    
    }

    //Función privada que devuelve un booleano
    private bool MilitarAtacaAldeano(Militar m, Aldeano a){
        
        a.SerAtacado(m.Atacar());
        //se podría poner directamente return a.getViva(); y no haría falta el if y else
        if(a.getViva()){
            return true;            
        }
        else{
            return false;
        }
        
    
    */

    /* 
        Ejercicio final: Crea dos listas, una del equipo rojo y otra del azul. Las listas contendrán todas las unidades de cada equipo.
        Crea las clases guerrero y arquero.
        Crea dos aldeanos para cada equipo. Crea un edificio para cada equipo. Crea un guerrero y un arquero por equipo.
        El guerrero ataca 10 y el arquero 5.
        Haz que uno de los dos aleatoriamente, ataque a una de las cuatro unidades aleatoriamente (asumimos que están en rango de ataque)
        Si una unidad ya murió debe notificarse, pero si le atacan se pasa el turno.
        En cada unidad de tiempo, atacará uno de los dos equipos aleatoriamente.
        Imprime por pantalla lo que pasa y quién gana.

    */

    // List<Unidade> vermellos = new List<Unidade>();
   // vermellos.Add(new Militar("Pedro", 10));
   // ((Militar)) vermellos[0]).atacar();      Raycast del primer elemento
    
        //Creo y defino la 1º clase
        List<Unidades> EquipoAzul = new List<Unidades>(){
            new Aldeano(" Aldeano Azul Primero"),
            new Aldeano(" Aldeano Azul Segundo"),  
            new Edificios(" Edificio Azul"),
            new Guerrero(" Guerrero Azul", 10),
            new Arquero(" Arquero Azul", 5)
            };

        //Creo y defino la 2º lista
        List<Unidades> EquipoRojo = new List<Unidades>(){
            new Aldeano(" Aldeano Rojo Primero"),
            new Aldeano(" Aldeano Rojo Segundo"),  
            new Edificios(" Edificio Rojo"),
            new Guerrero(" Guerrero Rojo", 10),
            new Arquero(" Arquero Rojo", 5)
        };


        //int eleccion = Random.Range(0,2);

        //defino el elemento que se hara aleatorio
        int eleccion;   

        

        
        //Cuando todos estan vivos todos los elementos de las 2 listas 
         while (EquipoAzul[0].getViva() && EquipoAzul[1].getViva() && EquipoAzul[2].getViva() && EquipoAzul[3].getViva() && EquipoAzul[4].getViva() || EquipoRojo[0].getViva() && EquipoRojo[1].getViva() && EquipoRojo[2].getViva() && EquipoRojo[3].getViva() && EquipoRojo[4].getViva()){
             //Numero aleatorio que sera 0 o 1
             
             //Numero aleatorio que sera 0 o 1
        eleccion = Random.Range(0,2);
            
            if(eleccion==1){
                    EquipoRojo[Random.Range(0,4)].SerAtacado(((Militar)EquipoRojo[Random.Range(3, 5)]).Atacar());
                    if( ! EquipoAzul[0].getViva() && ! EquipoAzul[1].getViva() && ! EquipoAzul[2].getViva() && ! EquipoAzul[3].getViva() && ! EquipoAzul[4].getViva()){
                        Debug.Log("Ganó el Rojo");
                        break;
                    }

                EquipoRojo[Random.Range(0,4)].SerAtacado(((Militar)EquipoAzul[Random.Range(3, 5)]).Atacar());
                if( ! EquipoRojo[0].getViva() && ! EquipoRojo[1].getViva() && ! EquipoRojo[2].getViva() && ! EquipoRojo[3].getViva() && ! EquipoRojo[4].getViva()){
                        Debug.Log("Ganó el Azul");
                        break; 
                    }
            }

            else{
                
            EquipoRojo[Random.Range(0,4)].SerAtacado(((Militar)EquipoAzul[Random.Range(3, 5)]).Atacar());
              if( ! EquipoRojo[0].getViva() && ! EquipoRojo[1].getViva() && ! EquipoRojo[2].getViva() && ! EquipoRojo[3].getViva() && ! EquipoRojo[4].getViva()){
                    Debug.Log("Ganó el Azul");
                    break; 
                }
            EquipoAzul[Random.Range(0,4)].SerAtacado(((Militar)EquipoRojo[Random.Range(3, 5)]).Atacar());
                if(! EquipoAzul[0].getViva() && ! EquipoAzul[1].getViva() && ! EquipoAzul[2].getViva() && ! EquipoAzul[3].getViva() && ! EquipoAzul[4].getViva()){
                    Debug.Log("Ganó el Rojo");
                    break;
                }
            }
        }     
    }

    private bool TodosMuertos(List<Unidades> equipos){
        
        for (int i=0; i < equipos.Count; i++){
            if(equipos[i].getViva()){   
                Debug.Log("HAN PALMADO");
                return false;
                
            }
        }

        return true;
        
        
        //Si aldeano 1 ha muerto de cualquiera de los 2 equipos aparece correctamente la frase "Gano el ..." SI muere cualquier otro miembro de la lista no
      
    
    }
}

           