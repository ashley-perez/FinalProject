using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Light[] lights;

    public bool plateState = true;

    public int cluesFound = 0;

    void Start()
    {
        foreach(Light light in lights)
        {
            light.enabled = false;
        }
    }

    void Update()
    {
        if (plateState && lights[0].enabled && lights[1].enabled && lights[2].enabled && lights[3].enabled && lights[4].enabled)
        {
            plateState = false;
            cluesFound += 1;
        }
    }
}
