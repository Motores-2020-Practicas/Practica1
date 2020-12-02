using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cae : MonoBehaviour
{
    public float minVel;
    public float maxVel;
    private float vel;
    void Start()
    {
        vel = Random.Range(Mathf.Abs(minVel), Mathf.Abs(maxVel));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f, -vel * Time.deltaTime, 0.0f);
    }
}
