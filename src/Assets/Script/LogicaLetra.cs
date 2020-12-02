using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaLetra : MonoBehaviour
{
    //Identifica el KeyCode del input del caracter
    KeyCode key;
    //Componente TextMesh
    TextMesh tMesh;

    void Start()
    {
        char caracter;
        int min = 97, max = 123;

        //Sirve para determinar si generar numeros o letras minúsculas,
        //dado que se siguen los caracteres del codigo ascii y estos 2 grupos no estan contiguos
        //0 -> NUM // 1 -> Letra
        int choice = Random.Range(0, 2);
        if (choice == 0)
        {
            min = 48;
            max = 58;
        }
        else
        {
            min = 97;
            max = 123;
        }

        //Se escoge una carácter random del código ascii
        caracter = (char)Random.Range(min, max);
        //Se guarda el KeyCode para comprobar el input posteriormente
        key = (KeyCode)caracter;

        //Se escoge un nuevo choice para saber si será mayúscula o minúscula
        //0 -> Min // 1 -> Mayus
        //En caso de ser un número, da igual si se hace upper o no, va a seguir siendo el mismo
        tMesh = GetComponent<TextMesh>();
        choice = Random.Range(0, 2);
        if (choice == 0)
        {
            tMesh.text = caracter.ToString();
        }
        else
        {
            tMesh.text = caracter.ToString().ToUpper();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            Destroy(this.gameObject);
        }
    }
}
