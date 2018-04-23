using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupCollide : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        if (other.tag == "Player" || other.tag == "Shield")
        {
            Destroy(gameObject);
        }
    }
}
