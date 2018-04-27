using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldActive : MonoBehaviour

{
    public GameObject shield;
    

    void OnTriggerEnter(Collider other)
    {
       /* if (other.tag == "Boundary")
        {
            return;
        }*/

        if(other.tag == "Powerup")
        {
            shield.gameObject.SetActive(true);
        }

        if(other.tag == "Enemy")
        {
            shield.gameObject.SetActive(false);
        }
    }
}
