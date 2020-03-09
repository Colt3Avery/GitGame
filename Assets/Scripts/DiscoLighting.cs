using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoLighting : MonoBehaviour
{
    public Light discoLight;
    public Color discoLightColor;
    private Color[] colors = new Color[6];
    // Start is called before the first frame update
    void Start()
    {
        discoLightColor = Color.magenta;

        for (int i = 0; i < 6; i++)
        {
            colors[i] = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            Debug.Log(colors[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 20 == 0)
        {
            discoLight.enabled = false;
        }
        else
        {
            discoLight.enabled = true;
        }
        discoLight.color = colors[Time.frameCount % 6];
    }
}