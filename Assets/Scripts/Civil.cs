using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Civil : Persona
{
    /*
    while (EquipoAzul[0].getViva() && EquipoAzul[1].getViva() && EquipoAzul[2].getViva() && EquipoAzul[3].getViva() && EquipoAzul[4].getViva() || EquipoRojo[0].getViva() && EquipoRojo[1].getViva() && EquipoRojo[2].getViva() && EquipoRojo[3].getViva() && EquipoRojo[4].getViva()){
             //Numero aleatorio que sera 0 o 1
             eleccion = Random.Range(0,2);
            
            if(eleccion==1){
                    

                EquipoRojo[Random.Range(0,5)].SerAtacado(((Militar)EquipoAzul[Random.Range(3, 5)]).Atacar());
                if( ! EquipoRojo[3].getViva() && ! EquipoRojo[4].getViva()){
                        Debug.Log("Ganó el Azul");
                        break; 
                    }
            }

            else{
                
            
            EquipoAzul[Random.Range(0,5)].SerAtacado(((Militar)EquipoRojo[Random.Range(3, 5)]).Atacar());
                if(! EquipoAzul[3].getViva() && ! EquipoAzul[4].getViva() ){
                    Debug.Log("Ganó el Rojo");
                    break;
                }
            }
        }     
    }
    */
}
