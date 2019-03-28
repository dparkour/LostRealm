using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public Material mat;
    public Color col;
    public Color col2;

    public bool activated;

    // Update is called once per frame
    void Update()
    {
        if(activated)
            mat.SetColor(Shader.PropertyToID("_EmissionColor"),  col);
        else
            mat.SetColor(Shader.PropertyToID("_EmissionColor"), col2);

    }
}
