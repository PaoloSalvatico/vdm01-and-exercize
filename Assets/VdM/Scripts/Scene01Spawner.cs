using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Spawner : MonoBehaviour
{
    public GameObject prefab;
    
    Quaternion rotate;


    
    void Update()
    {
        var btnDown = Input.GetKeyDown(KeyCode.Mouse0);

        if (btnDown)
        {
            rotate = Random.rotation;
            // Debug.Log("left click");
            GameObject.Instantiate(prefab, transform.position, rotate);
        }
    }
}
