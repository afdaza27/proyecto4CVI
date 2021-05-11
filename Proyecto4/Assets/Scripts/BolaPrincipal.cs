using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BolaPrincipal : MonoBehaviour
{
    Material material;
    int multiplicadorGrosor = 1;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        CambiarGrosor();
    }

    void CambiarGrosor()
    {
        //TextureDimension thickness = material.shader.GetPropertyTextureDimension(2);
    }
}
