using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light[] lights;
    
    public void Switch(float index)
    {
        int len = lights.Length;
        for (int i = 0; i < len; i++)
        {
            lights[i].enabled = !lights[i].enabled;
        }
    }
}
