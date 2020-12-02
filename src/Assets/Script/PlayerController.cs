using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Velocidad de movimiento m/s
    public float unitPerSec;
    //Ancho del mundo
    const float anchoMundo = 16.0f;
    //Offset del objeto para comprobar que no se salga de los limites
    float offset;

    void Start()
    {
        offset = transform.localScale.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Posicion x de la pala
        float pos_x = transform.position.x;
        //Velocidad a la que se moverá la pala. Así se evita llamar transform.Translate dos veces
        float velocity = 0;

        if (Input.GetKey(KeyCode.RightArrow) && pos_x + offset < anchoMundo / 2)
        {
            velocity = unitPerSec * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && pos_x - offset > -anchoMundo / 2)
        {
            velocity = -unitPerSec * Time.deltaTime;
        }

        transform.Translate(velocity, 0.0f, 0.0f);
    }
}
