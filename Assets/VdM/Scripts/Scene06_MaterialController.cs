using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene06_MaterialController : MonoBehaviour
{
    MeshRenderer mesh;
    KeyCode changeColor = KeyCode.Space;
    KeyCode changeMeth = KeyCode.A;

    public Material meth;
    
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(changeColor))
        {
            mesh.material.color = Random.ColorHSV();
        }

        if(Input.GetKeyDown(changeMeth))
        {
            meth.color = Random.ColorHSV();
        }
    }
}
