using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private ShootingManager manager;

    void Start()
    {
        // Encontrar el controlador central (asegúrate de que haya un ShootingManager en la escena)
        manager = FindObjectOfType<ShootingManager>();

        // Registrar la bala en el controlador
        if (manager != null)
        {
            manager.RegistrarBala(gameObject);
        }
    }

    void OnDestroy()
    {
        // Eliminar la bala del controlador
        if (manager != null)
        {
            manager.EliminarBala(gameObject);
        }
    }

}
