using UnityEngine;
using System.Collections;

public class ColorLerp : MonoBehaviour {
    public float sat = 1;
    public float value = 1;
    public float duration = 1.0F;
    public Renderer rend;
    void Start() {
        rend = GetComponent<Renderer>();
    }
    void Update() {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        float lerpHue = Mathf.Lerp(-0.16f, 1.16f, lerp);
        //float lerpSaturation = Mathf.Lerp(200, 300, lerp);
        rend.material.color = Color.HSVToRGB(lerpHue, sat, value);
        rend.material.SetColor("_EmissionColor", rend.material.color);
    }
}