using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Danyo : MonoBehaviour
{
    //Camara principal de la escena
    private Camera camera_;
    //Contador para empezar a infligir daño
    private float counter;  
    //Cantidad de daño acumulada
    private float daño;

    void Start()
    {
        camera_ = Camera.main;
        camera_.backgroundColor = new Color(0.0f, 0.0f, 0.0f);
        counter = 3.0f;
        daño = 0.0f;
    }

    private void Update()
    {
        //Cambia de escena y finaliza el juego
        if (daño >= 1.0f) {
            SceneManager.LoadScene("GameOver");
        }

        //Pierde un 1% de daño por segundo
        if (daño > 0.0f) {
            daño -= 0.01f * Time.deltaTime;
            camera_.backgroundColor = new Color(daño, daño, daño);
        }
    }

    /// <summary>
    ///Cambia el color del background de la camara en función de daño,
    ///haciéndose cada vez más blanco
    /// </summary>
    public void dealDamage() {
        if (counter == 0)
        {
            daño += 0.1f;
            if (daño >= 1.0f) daño = 1.0f;
            camera_.backgroundColor = new Color(daño, daño, daño);
        }
        else counter--;
    }
}
