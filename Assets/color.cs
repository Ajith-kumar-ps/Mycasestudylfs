using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerboardTexture : MonoBehaviour
{
    public int textureSize = 1024; // Size of the texture
    public int gridSize = 20; // Number of squares along one dimension

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = GenerateCheckerboardTexture();
    }

    Texture2D GenerateCheckerboardTexture()
    {
        Texture2D texture = new Texture2D(textureSize, textureSize);

        Color color1 = Color.black;
        Color color2 = Color.white;

        for (int y = 0; y < textureSize; y++)
        {
            for (int x = 0; x < textureSize; x++)
            {
                // Determine which color to use
                bool useFirstColor = ((x / (textureSize / gridSize)) % 2 == 0) ^ ((y / (textureSize / gridSize)) % 2 == 0);
                texture.SetPixel(x, y, useFirstColor ? color1 : color2);
            }
        }

        texture.Apply();
        return texture;
    }
}
