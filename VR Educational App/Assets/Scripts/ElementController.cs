using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementController : MonoBehaviour
{
    public bool isFlammable = true;
    public bool conductsElectricity = true;
    public bool isMagnetic = true;
    public bool isSoluble = true;
    public float mass = 1f;
    public float volume = 1f;

    public float GetDensity()
    {
        return mass / volume;
    }
}
