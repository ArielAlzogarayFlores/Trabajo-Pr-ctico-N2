using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    public int EdadUsuario;
    public Text miTexto;
  
    void Start()
    {

        if (EdadUsuario > 18)
        {
            miTexto.text = "Es mayor de edad.";
            Debug.Log("Es mayor de edad.");
        }
        else
        {
            miTexto.text = "No es mayor de edad.";
            Debug.Log("No es mayor de edad.");
        }

    }
}
