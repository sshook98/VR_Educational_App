using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleController : MonoBehaviour
{
    [SerializeField]
    private Text scaleText;

    void Start()
    {
        if (scaleText == null)
        {
            Debug.LogError("scaleText not setup correctly on " + name);
        } else
        {
            scaleText.text = "Mass: \nVolume: n";
        }
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.tag == "Element")
        {
            ElementController ec = other.GetComponent<ElementController>();

            float mass = ec.GetMass();
            float volume = ec.GetVolume();
            scaleText.text = "Mass: " + mass + "\n" + "Volume: " + volume;
        }
    }
}
