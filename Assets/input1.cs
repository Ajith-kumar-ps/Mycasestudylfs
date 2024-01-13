using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    public Color newColor = new Color(0.1098f, 0.4941f, 0.8314f); // RGB values for "1C7ED4"

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (rend != null)
        {
            Material material = rend.material;
            material.SetColor("_BaseColor", newColor);
        }
        else
        {
            Debug.LogError("Renderer component not found on GameObject.");
        }
    }
}
