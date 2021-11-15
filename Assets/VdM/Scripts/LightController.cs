using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    Light[] findLight;
    public float lightPercent;
    

    void Start()
    {
        SwitchOff();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) On_Off();
        if (Input.GetKeyDown(KeyCode.Alpha2)) RandomSwitch();
        if (Input.GetKeyDown(KeyCode.Alpha3)) SelectNumberOfSwitch();
    }

    void SwitchOff()
    {
        findLight = FindObjectsOfType<Light>();
        foreach(Light l in findLight)
        {
            l.enabled = false;
        }
    }

    void On_Off()
    {
        foreach (Light light in findLight)
        {
            light.enabled = !light.enabled;
        }
    }

    void RandomSwitch()
    {
        
        foreach(Light l in findLight)
        {
            int random = Random.Range(0, 2);
            if (random == 0) l.enabled = !l.enabled;
        }
    }

    void SelectNumberOfSwitch()
    {
        int numberOfLightToSwitch = Mathf.RoundToInt(findLight.Length * lightPercent);

        for (int counter = 0; counter < findLight.Length; counter++)
        {
            if (counter < numberOfLightToSwitch)
            {
                findLight[counter].enabled = true;
            }
            else findLight[counter].enabled = false;
        }
    }
}
