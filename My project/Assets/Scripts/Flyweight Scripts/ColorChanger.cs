using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private new Renderer renderer;
    private MaterialPropertyBlock propblock;
    private void Awake()
    {
        renderer = GetComponent<Renderer>();
        propblock = new MaterialPropertyBlock();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //renderer.material.color = GetRandomColor();
        renderer.GetPropertyBlock(propblock);
        propblock.SetColor("Color",GetRandomColor());
        renderer.SetPropertyBlock(propblock);
    }
    private Color GetRandomColor()
    {
        return new Color(
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f)
            );
    }
}
