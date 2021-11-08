using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject[] LightArray;
    Light _light;

    void Start()
    {
        GameObject [] findLights = LightArray;
        CreateArray();

        

    }

    
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(_light.enabled)
            {
                _light.enabled = false;
            }
            _light.enabled = true;
        }
    }

    void CreateArray()
    {
        foreach(var l in FindObjectsOfType<Light>())
        {
            for(int i = 0; i < LightArray.Length; i++)
            LightArray.SetValue(l, i);
        }
    }
}
