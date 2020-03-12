using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementController : MonoBehaviour
{
    [SerializeField]
    private bool isFlammable = true;
    [SerializeField]
    private bool conductsElectricity = true;
    [SerializeField]
    private bool isMagnetic = true;
    [SerializeField]
    private bool isSoluble = true;
    [SerializeField]
    private float mass = 1f;
    [SerializeField]
    private float volume = 1f;

    public bool IsFlammable()
    {
        return isFlammable;
    }

    public bool ConductsElectricity()
    {
        return conductsElectricity;
    }

    public bool IsMagnetic()
    {
        return isMagnetic;
    }

    public bool IsSoluble()
    {
        return isSoluble;
    }

    public float GetMass()
    {
        return mass;
    }

    public float GetVolume()
    {
        return volume;
    }

    public float GetDensity()
    {
        return mass / volume;
    }
}
