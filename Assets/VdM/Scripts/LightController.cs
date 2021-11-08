using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public ArrayList[] LightArray;
    Light _light;

    void Start()
    {
        //LightArray = _light.FindObjectsOfType<Light>();


        SwitchOff();

    }

    
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(_light.enabled)
            {
                _light.enabled = false;
            }
            if (_light.enabled == false)
            {
                _light.enabled = true;
            }
               
        }
    }

    void SwitchOff()
    {
        foreach(var l in FindObjectsOfType<Light>())
        {
            l.enabled = false;
        }
    }
}
