using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private Danyo dan = null;

    void Start()
    {
        //Si el GO es la DeathZone entonces podrá hacer daño
        if (this.gameObject.name == "DeathZone")
        {
            dan = this.GetComponent<Danyo>();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (dan != null)
        {
            //Hace daño
            dan.dealDamage();
        }
    }
}
