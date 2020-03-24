using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConductivityController : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    private void onTriggerEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.tag.Equals("Element"))
        {
            ElementController ec = other.GetComponent<ElementController>();

            if (ec.ConductsElectricity()) {
                GetComponent<ParticleSystem>().Play();
                ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
                em.enabled = true;
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        GameObject other = collision.gameObject;
        if (other.tag.Equals("Element"))
        {
            ElementController ec = other.GetComponent<ElementController>();

            if (ec.ConductsElectricity())
            {
                GetComponent<ParticleSystem>().Stop();
                ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission;
                em.enabled = false;
            }
        }
    }
}
