using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string ejercicio;
    public int horas;
    float precio;

    // Start is called before the first frame update
    void Start()
    {
     if (ejercicio != "cardio" && ejercicio != "fuerza" && ejercicio != "recreativo")
        {
            Debug.Log("Tipo de ejercicio no valido,  solo se puede cardio, fuerza o recreativo");
            return;
        }

        if (horas < 1 || horas > 6)
        {
            Debug.Log("La cantidad de horas minima es 1 y maxima 6");
            return;
        }

        if (ejercicio == "fuerza")
        {
            precio = horas * 1500;
            Debug.Log("El ejercicio elegido es Fuerza, y se reservaron " + horas + " horas");

            if (horas == 6)
            {
                Debug.Log("El precio sin el descuento es " + precio);
                precio = precio * 0.90f;
                Debug.Log("El precio con el descuento es " + precio);
            }
            else
            {
                Debug.Log("El precio es " + precio);
            }
        }
        if (ejercicio == "recreativo")
        {
            precio = horas * 2500;
            Debug.Log("El ejercicio elegido es recreativo, y se reservaron " + horas + " horas");

            if (horas == 6)
            {
                Debug.Log("El precio sin el descuento es " + precio);
                precio = precio * 0.90f;
                Debug.Log("El precio con el descuento es " + precio);
            }
            else
            {
                Debug.Log("El precio es " + precio);
            }
        }
        if (ejercicio == "cardio")
        {
            precio = horas * 1000;
            Debug.Log("El ejercicio elegido es cardio, y se reservaron " + horas + " horas");

            if (horas == 6)
            {
                Debug.Log("El precio sin el descuento es " + precio);
                precio = precio * 0.90f;
                Debug.Log("El precio con el descuento es " + precio);
            }
            else
            {
                Debug.Log("El precio es " + precio);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
