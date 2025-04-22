using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICapalooza : MonoBehaviour
{
    public int vendidasPlatea;
    public int vendidasCampo;
    int precioPlatea = 2000;
    int precioCampo = 1200;
    int maximoPlatea = 20400;
    int maximoCampo = 16200;
    int vacantesPlatea;
    int vacantesCampo;
    int recaudoPlatea;
    int recaudoCampo;
    int recaudoTotal;
    int espacioTotal;
    // Start is called before the first frame update
    void Start()
    {
        espacioTotal = maximoCampo + maximoPlatea;
        if(vendidasPlatea < 0|| vendidasCampo < 0)
        {
            Debug.Log("La cantidad de entradas no puede ser menor a 0");
            return;
        } else if(vendidasPlatea > maximoPlatea || vendidasCampo > maximoCampo)
        {
            Debug.Log("Error: la cantidad de entradas vendidas supera al limite del predio");
            return;
        }
        vacantesPlatea = maximoPlatea - vendidasPlatea;
        vacantesCampo = maximoCampo - vendidasCampo;
        recaudoPlatea = vendidasPlatea * precioPlatea;
        recaudoCampo = vendidasCampo * precioCampo;
        recaudoTotal = recaudoCampo + recaudoPlatea;
        if(vendidasCampo + vendidasPlatea >= espacioTotal / 2)
        {
            Debug.Log("El festival fue un exito");
        } else
        {
            Debug.Log("Debemos mejorar la convocatoria");
        }
        if (vacantesCampo == 0 && vacantesPlatea == 0)
        {
            Debug.Log("sold Out");
        }
        else {
            Debug.Log("Quedan " + (vacantesPlatea + vacantesCampo) + " vacantes");
        }
        Debug.Log("Se recaudó: " + recaudoCampo + "$ en entradas de campo");
        Debug.Log("Se recaudó: " + recaudoPlatea + "$ en entradas de Platea");
        Debug.Log("Se recaudó: " + recaudoTotal + "$ en Total");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
