using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Tiempo mínimo del spawn
    public float minSpawnRate;
    //Tiempo máximo del spawn
    public float maxSpawnRate;
    float timeToCreate;
    //Posicion y del Spawner
    float pos_y;
    //Prefab del GO a generar
    public GameObject letra;
    //Limite derecho del objeto
    float maxBound;
    //Limite izquierdo del objeto
    float minBound;

    void Start()
    {
        pos_y = transform.position.y;
        timeToCreate = Random.Range(minSpawnRate, maxSpawnRate);
        maxBound = GetComponent<MeshRenderer>().bounds.max.x;
        minBound = GetComponent<MeshRenderer>().bounds.min.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeToCreate <= 0) {
            //Nueva posición random del objeto.
            Vector3 position = new Vector3(Random.Range(minBound, maxBound), pos_y, 0.0f);
            //Genera el objeto random
            Instantiate<GameObject>(letra, position, Quaternion.identity);
            //Reseteo del tiempo de creación
            timeToCreate = Random.Range(minSpawnRate, maxSpawnRate);
        }

        //Timer
        timeToCreate -= Time.deltaTime;
    }
}
