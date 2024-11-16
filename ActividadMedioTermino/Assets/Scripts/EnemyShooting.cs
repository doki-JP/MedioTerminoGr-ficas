using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject proyectilPrefab; 
    public Transform puntoDeDisparo;  
    public float velocidadProyectil = 20f;
    public float intervaloDisparoMin = 1f;
    public float intervaloDisparoMax = 15f;
    public float tiempoVidaProyectil = 15f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Disparar", Random.Range(intervaloDisparoMin,intervaloDisparoMax));

    }

    void Disparar()
    {
        // Instancia el proyectil en el punto de disparo y en la direcci�n de la torreta
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDeDisparo.position, puntoDeDisparo.rotation);

        // Aseg�rate de que el proyectil tiene un Rigidbody para a�adir velocidad
        Rigidbody rb = proyectil.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = puntoDeDisparo.forward * velocidadProyectil;
        }

        // Opcional: Destruir el proyectil despu�s de unos segundos para optimizar memoria
        Destroy(proyectil, tiempoVidaProyectil);

        Invoke("Disparar", Random.Range(intervaloDisparoMin, intervaloDisparoMax));
    }
}
