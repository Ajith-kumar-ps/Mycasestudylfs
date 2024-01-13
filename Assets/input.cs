using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    void Start()
    {
        // Create a new color with RGB values. Divide by 255.0f to convert to 0-1 range.
        Color newColor = new Color(28/255.0f, 126/255.0f, 212/255.0f);

        // Assign the new color to the material of the Renderer component.
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = newColor;
        }
    }
}
