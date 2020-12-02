using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    //Prefab del GO a generar
    public GameObject letra;

    //Tiempo mínimo del spawn
    public float minSpawnRate;
    //Tiempo máximo del spawn
    public float maxSpawnRate;

    //Posicion y del Spawner
    float pos_y;
    //Limite derecho del objeto
    float maxBound;
    //Limite izquierdo del objeto
    float minBound;

    void Start() {
        pos_y = transform.position.y;
        Invoke("SpawnObject", Random.Range(minSpawnRate, maxSpawnRate + 1));
        maxBound = GetComponent<MeshRenderer>().bounds.max.x;
        minBound = GetComponent<MeshRenderer>().bounds.min.x;
    }

    //Crea el objeto nuevo y prepara el siguiente
    void SpawnObject() {
        Invoke("SpawnObject", Random.Range(minSpawnRate, maxSpawnRate + 1));

        //Nueva posición random del objeto.
        Vector2 posicion = new Vector2(Random.Range(minBound, maxBound + 0.1f), pos_y);

        Instantiate(letra, posicion, Quaternion.identity);
    }
}
