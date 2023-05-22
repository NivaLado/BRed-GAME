using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorPass : MonoBehaviour {
    Renderer rend;
    // Use this for initialization
    void Start () {
       rend = GetComponent<Renderer>();
       rend.material.SetVector("_PlayerTransform", new Vector4(10, 1, 1, 1));
    }

    private void Update()
    {
        rend.material.SetVector("_PlayerTransform", new Vector4(10, 1, 1, 1));
    }
}
