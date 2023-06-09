using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public Vector2 speed = Vector2.zero;
    public Vector2 offset = Vector2.zero;

    private Material Material;
    void Start()
    {
        Material = GetComponent<Renderer>().material;
        offset = Material.GetTextureOffset("_MainTex");
    }


    void Update()
    {
        offset += speed * Time.deltaTime;
        Material.SetTextureOffset("_MainTex", offset);
    }
}
