using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotar();
    }

    void Rotar()
    {
        transform.Rotate(new Vector3(0.1f, 0.1f, 0.1f));
    }
}
