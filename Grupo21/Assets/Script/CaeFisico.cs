using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaeFisico : MonoBehaviour
{
    public float minVel;
    public float maxVel;
    private float force;
    void Start()
    {
        force = Random.Range(Mathf.Abs(minVel), Mathf.Abs(maxVel)) * 100;

        GetComponent<Rigidbody>().AddForce(Vector3.down * force);
    }
}
