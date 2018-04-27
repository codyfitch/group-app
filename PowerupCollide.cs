using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupCollide : MonoBehaviour {

    public GameObject PowerS;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        if (other.tag == "Player" || other.tag == "Shield")
        {
            //PowerS.SetActive(false);
            Destroy(PowerS);
        } 
    }
}
